using System;
using System.Collections.Generic;

public class Search
{
    private int nodesVisitedCount;
    private int[,] graph;
    private bool[] visited;
    private int numVertices;
    private int[] parent;
    //IAD 10/15/2024: Constructor for the search class.
    public Search(int[,] graph)
    {
        this.graph = graph;
        this.numVertices = graph.GetLength(0);
        this.visited = new bool[numVertices];
        this.parent = new int[numVertices];
        nodesVisitedCount = 0;
        resetVisited();
    }
    //IAD 10/15/2024: Performs a depth first search on the graph.
    public void DepthFirstSearch(int vertex)
    {
        visited[vertex] = true;
        nodesVisitedCount++;
        Console.WriteLine("Visiting vertex " + vertex);

        if (vertex == 9)
        {
            Console.WriteLine("Reached vertex 9");
            return;
        }

        for (int v = 0; v < numVertices; v++)
        {
            if (graph[vertex, v] != -1 && !visited[v])
            {
                parent[v] = vertex;
                DepthFirstSearch(v);
            }
        }
    }
    //IAD 10/15/2024: Performs a breadth first search on the graph.
    public void BreadthFirstSearch(int startVertex)
    {
        resetVisited();
        Queue<int> queue = new Queue<int>();
        visited[startVertex] = true;
        parent[startVertex] = -1;
        queue.Enqueue(startVertex);

        while (queue.Count > 0)
        {
            int vertex = queue.Dequeue();
            Console.WriteLine("Visiting vertex " + vertex);

            if (vertex == 9)
            {
                Console.WriteLine("Reached vertex 9");
                break;
            }

            for (int v = 0; v < numVertices; v++)
            {
                if (graph[vertex, v] != -1 && !visited[v])
                {
                    visited[v] = true;
                    parent[v] = vertex;
                    queue.Enqueue(v);
                }
            }
        }
    }
    //IAD 10/15/2024: Resets the visited array and parent array to their default values.
    private void resetVisited()
    {
        for (int i = 0; i < visited.Length; i++)
        {
            visited[i] = false;
            parent[i] = -1;
        }
    }
    //IAD 10/15/2024: Returns the visited array of the search.
    public bool[] GetVisitedNodes() { return visited; }
    //IAD 10/15/2024: Returns the number of nodes visited during the search.
    public int GetNodesVisitedCount() { return nodesVisitedCount; }
    //IAD 10/15/2024: Returns the parent array of the search.
    public int[] GetParentArray() { return parent; }
    //IAD 10/15/2024: Returns a list of vertices that make up the path from the start vertex to the target vertex.
    public List<int> GetPath(int targetVertex)
    {
        List<int> path = new List<int>();
        int current = targetVertex;

        if (!visited[targetVertex])
        {
            return null;
        }

        while (current != -1)
        {
            path.Add(current);
            current = parent[current];
        }
        path.Reverse();
        return path;
    }
}
