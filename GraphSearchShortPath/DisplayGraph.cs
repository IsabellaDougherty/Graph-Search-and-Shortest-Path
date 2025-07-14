using circleOfLines;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace GraphSearchShortPath
{
    public partial class DisplayGraph : Form
    {
        CreateCircle circle = new CreateCircle();
        GenerateArray genArr = new GenerateArray();
        Search search = null;
        int numVertices;
        int targetVertex;
        bool isWeightedGraph;
        int[,] arr;
        int r;
        int c;
        double perc;
        Bitmap bmp;
        CirclesAndLinesDisplay display = new CirclesAndLinesDisplay();

        public DisplayGraph()
        {
            InitializeComponent();
            rdioDepth.Checked = true;
        }
        //IAD 10/15/2024: This method is called when the "Run" button is clicked. It generates a graph and displays it.
        private void btnRun_Click(object sender, EventArgs e)
        {
            numVertices = Convert.ToInt32(numVerts.Value);
            double percentage = Convert.ToDouble(numPerc.Value);

            GenerateArray genArray = new GenerateArray();
            int[,] graph;
            isWeightedGraph = false;
            if (rdioDijkstra.Checked)
            {
                isWeightedGraph = true;
                graph = genArray.GenerateWeightedGraph(numVertices, percentage / 100.0);
            }
            else
            {
                graph = genArray.genArr(numVertices, percentage / 100.0);
            }
            targetVertex = numVertices - 1;
            int bmpSize = Math.Min(pctBoxDisp.Width, pctBoxDisp.Height);
            Bitmap bmp = new Bitmap(bmpSize, bmpSize);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            Point[] vertexPositions = new Point[numVertices];
            int centerX = bmpSize / 2;
            int centerY = bmpSize / 2;
            int radius = bmpSize / 2 - 20;

            for (int i = 0; i < numVertices; i++)
            {
                double angle = i * (2 * Math.PI / numVertices);
                int x = centerX + (int)(radius * Math.Cos(angle));
                int y = centerY + (int)(radius * Math.Sin(angle));
                vertexPositions[i] = new Point(x, y);
            }
            List<int> path = null;
            int totalDistance = 0;
            bool[] visitedNodes = new bool[numVertices];
            Search search = null;
            if (rdioDepth.Checked)
            {
                search = new Search(graph);
                search.DepthFirstSearch(0);
                visitedNodes = search.GetVisitedNodes();
                path = search.GetPath(targetVertex);
            }
            else if (rdioBreadth.Checked)
            {
                search = new Search(graph);
                search.BreadthFirstSearch(0);
                visitedNodes = search.GetVisitedNodes();
                path = search.GetPath(targetVertex);
            }
            else if (rdioDijkstra.Checked)
            {
                Dijkstra dijkstra = new Dijkstra(graph);
                dijkstra.FindShortestPath(0);
                path = dijkstra.GetShortestPath(targetVertex);
                totalDistance = dijkstra.GetTotalDistance(targetVertex);
                int[] distances = dijkstra.GetDistances();
                for (int i = 0; i < numVertices; i++)
                {
                    visitedNodes[i] = distances[i] != int.MaxValue;
                }
                int nodesVisited = dijkstra.GetNodesVisitedCount();
                txtBoxOut.Text += $"Nodes Visited: {nodesVisited}\n";
            }
            for (int u = 0; u < numVertices; u++)
            {
                for (int v = 0; v < numVertices; v++)
                {
                    if (graph[u, v] != -1)
                    {
                        Point from = vertexPositions[u];
                        Point to = vertexPositions[v];
                        int weight = graph[u, v];
                        if (isWeightedGraph)
                        {
                            display.DrawEdge(g, from, to, 0, weight);
                        }
                        else
                        {
                            display.DrawEdge(g, from, to, 0);
                        }
                    }
                }
            }
            if (path != null)
            {
                for (int i = 0; i < path.Count - 1; i++)
                {
                    int u = path[i];
                    int v = path[i + 1];
                    Point from = vertexPositions[u];
                    Point to = vertexPositions[v];
                    int weight = graph[u, v];
                    if (isWeightedGraph)
                    {
                        display.DrawEdge(g, from, to, 2, weight);
                    }
                    else
                    {
                        display.DrawEdge(g, from, to, 2);
                    }
                }
            }
            for (int i = 0; i < numVertices; i++)
            {
                Point position = vertexPositions[i];
                int colorCode = visitedNodes[i] ? 1 : 0;
                display.DrawNode(g, position, colorCode, 15, i.ToString());
            }
            pctBoxDisp.Image = bmp;
            txtBoxOut.Clear();
            if (isWeightedGraph)
            {
                txtBoxOut.Text += genArray.DisplayWeightedGraph(graph) + "\n";
                if (path != null)
                {
                    txtBoxOut.Text += $"Shortest Path from 0 to {targetVertex}: " + string.Join(" -> ", path) + "\n";
                    txtBoxOut.Text += "Total Distance: " + totalDistance + "\n";
                    txtBoxOut.Text += "Edge Weights along the Path: ";
                    for (int i = 0; i < path.Count - 1; i++)
                    {
                        int u = path[i];
                        int v = path[i + 1];
                        txtBoxOut.Text += graph[u, v] + (i < path.Count - 2 ? " + " : "");
                    }
                    txtBoxOut.Text += " = " + totalDistance + "\n";
                }
                else
                {
                    txtBoxOut.Text += $"No path from vertex 0 to vertex {targetVertex}\n";
                }
            }
            else
            {
                txtBoxOut.Text += "Adjacency Matrix:\n" + genArray.testDisplay(graph) + "\n";
                if (path != null)
                {
                    txtBoxOut.Text += $"Path from 0 to {targetVertex}: " + string.Join(" -> ", path) + "\n";
                    txtBoxOut.Text += $"Path Length: {path.Count - 1}\n";
                    int nodesVisited = search.GetNodesVisitedCount();
                    txtBoxOut.Text += $"Nodes Visited: {nodesVisited}\n";
                }
                else
                {
                    txtBoxOut.Text += $"No path from vertex 0 to vertex {targetVertex}\n";
                }
            }
        }
        //IAD 10/15/2024: This method is called to display the graph as a string in the text box.
        public String testBools(int[,] arr)
        {
            String disp = "";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == -1)
                    {
                        disp += "  |  ";
                    }
                    else
                    {
                        disp += " O ";
                    }
                }
                disp += Environment.NewLine;
            }
            return disp;
        }
        //IAD 10/15/2024: This method is used to change the colors of the nodes and lines
        public int[,] colorGraph(bool[,] v, int c)
        {
            int[,] visits = new int[v.GetLength(0), v.GetLength(1)];
            for (int row = 0; row < v.GetLength(0); row++) { for (int col = 0; col < v.GetLength(1); col++) { if (v[row, col]) { visits[row, col] = c; } } }
            return visits;
        }
        //IAD 10/15/2024: These methods are called when the radio buttons are clicked to change the search type.
        private void rdioDepth_CheckedChanged(object sender, EventArgs e)
        {
            if ((rdioBreadth.Checked || rdioDijkstra.Checked) && rdioDepth.Checked)
            {
                search = new Search(arr);
                search.DepthFirstSearch(0);
                rdioDepth.Checked = true;
                rdioBreadth.Checked = false;
                rdioDijkstra.Checked = false;
                int nodesVisited = search.GetNodesVisitedCount();
                txtBoxOut.Text += $"Nodes Visited: {nodesVisited}\n";
            }
        }
        //IAD 10/15/2024: These methods are called when the radio buttons are clicked to change the search type.
        private void rdioBreadth_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioBreadth.Checked && (rdioDepth.Checked || rdioDijkstra.Checked))
            {
                search = new Search(arr);
                search.BreadthFirstSearch(0);
                rdioBreadth.Checked = true;
                rdioDepth.Checked = false;
                rdioDijkstra.Checked = false;
                int nodesVisited = search.GetNodesVisitedCount();
                txtBoxOut.Text += $"Nodes Visited: {nodesVisited}\n";
            }
        }
        //IAD 10/15/2024: These methods are called when the radio buttons are clicked to change the search type.
        private void rdioDijkstra_CheckedChanged(object sender, EventArgs e)
        {
            if ((rdioBreadth.Checked || rdioDepth.Checked) && rdioDijkstra.Checked)
            {
                rdioBreadth.Checked = false;
                rdioDepth.Checked = false;
                rdioDijkstra.Checked = true;
            }
        }
    }
}