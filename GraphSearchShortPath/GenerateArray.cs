using System;
using System.Text;

public class GenerateArray
{
    //IAD 10/15/2024: Generates a 2D array with a given size and percentage of cells filled.
    public int[,] genArr(int size, double perc)
    {
        int[,] arr = new int[size, size];
        int numVertices = arr.GetLength(0);
        int totalCells = numVertices * numVertices;
        int numToFill = (int)(totalCells * perc);
        Random rand = new Random();

        for (int i = 0; i < numVertices; i++)
        {
            for (int j = 0; j < numVertices; j++)
            {
                arr[i, j] = -1;
            }
        }
        while (numToFill > 0)
        {
            int from = rand.Next(0, numVertices);
            int to = rand.Next(0, numVertices);
            if (arr[from, to] == -1 && from != to)
            {
                arr[from, to] = 1;
                numToFill--;
            }
        }

        return arr;
    }
    //IAD 10/15/2024: Generates a weighted 2D array with a given size and percentage of cells filled.
    public int[,] GenerateWeightedGraph(int size, double percentage)
    {
        int[,] graph = new int[size, size];
        int totalCells = size * size;
        int numToFill = (int)(totalCells * percentage);
        Random rand = new Random();

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                graph[i, j] = -1;
            }
        }
        while (numToFill > 0)
        {
            int from = rand.Next(0, size);
            int to = rand.Next(0, size);
            if (graph[from, to] == -1 && from != to)
            {
                graph[from, to] = rand.Next(1, 21);
                numToFill--;
            }
        }

        return graph;
    }
    //IAD 10/15/2024: Returns a string of the 2D array
    public string testDisplay(int[,] arr)
    {
        string disp = "";
        int numVertices = arr.GetLength(0);
        for (int i = 0; i < numVertices; i++)
        {
            for (int j = 0; j < numVertices; j++)
            {
                disp += arr[i, j] == -1 ? " -1 " : "  1 ";
            }
            disp += Environment.NewLine;
        }
        return disp;
    }
    //IAD 10/15/2024: Returns a string of the weighted 2D array
    public string DisplayWeightedGraph(int[,] graph)
    {
        StringBuilder sb = new StringBuilder();
        int size = graph.GetLength(0);
        sb.AppendLine("Weighted Adjacency Matrix:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                sb.Append(graph[i, j] == -1 ? " -1 " : graph[i, j].ToString(" 00 "));
            }
            sb.AppendLine();
        }
        return sb.ToString();
    }
}

