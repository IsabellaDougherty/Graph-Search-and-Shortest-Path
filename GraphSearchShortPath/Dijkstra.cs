using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphSearchShortPath
{
    public class Dijkstra
    {
        private int[,] graph;
        private int size;
        private int[] distances;
        private int[] parent;
        private bool[] visited;
        private int nodesVisitedCount;
        //IAD 10/15/2024: Constructor for the Dijkstra class
        public Dijkstra(int[,] graph)
        {
            this.graph = graph;
            this.size = graph.GetLength(0);
            this.distances = new int[size];
            this.parent = new int[size];
            this.visited = new bool[size];
            this.nodesVisitedCount = 0;
        }

        //IAD 10/15/2024: Initialize distances and parent arrays
        public void FindShortestPath(int source)
        {
            for (int i = 0; i < size; i++)
            {
                distances[i] = int.MaxValue;
                parent[i] = -1;
                visited[i] = false;
            }
            distances[source] = 0;

            for (int count = 0; count < size - 1; count++)
            {
                int u = MinDistance();

                if (u == -1)
                    break;

                visited[u] = true;
                nodesVisitedCount++;

                for (int v = 0; v < size; v++)
                {
                    if (!visited[v] && graph[u, v] != -1 && distances[u] != int.MaxValue && distances[u] + graph[u, v] < distances[v])
                    {
                        distances[v] = distances[u] + graph[u, v];
                        parent[v] = u;
                    }
                }
            }
        }
        //IAD 10/15/2024: Returns the number of nodes visited
        public int GetNodesVisitedCount()
        {
            return nodesVisitedCount;
        }
        //IAD 10/15/2024: Returns the index of the node with the minimum distance
        private int MinDistance()
        {
            int min = int.MaxValue;
            int minIndex = -1;

            for (int v = 0; v < size; v++)
            {
                if (!visited[v] && distances[v] <= min)
                {
                    min = distances[v];
                    minIndex = v;
                }
            }
            return minIndex;
        }
        //IAD 10/15/2024: Returns the shortest path from the source to the target
        public List<int> GetShortestPath(int target)
        {
            if (distances[target] == int.MaxValue)
            {
                return null;
            }

            List<int> path = new List<int>();
            int current = target;
            while (current != -1)
            {
                path.Add(current);
                current = parent[current];
            }
            path.Reverse();
            return path;
        }
        //IAD 10/15/2024: Returns the total distance from the source to the target
        public int GetTotalDistance(int target)
        {
            return distances[target];
        }
        //IAD 10/15/2024: Returns the distances array
        public int[] GetDistances()
        {
            return distances;
        }
    }
}
