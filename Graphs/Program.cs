using System;
using System.Collections.Generic;

namespace Graphs
{
    class clsGraph
    {
        // Total number of vertices
        private int vertices;

        // Adjacency list array for all vertices
        private List<Int32>[] adj;

        // Constructor
        public clsGraph(int v)
        {
            vertices = v;
            adj = new List<Int32>[v];

            // Instantiate adjacency list for all vertices
            for(int i=0; i<v; i++)
            {
                adj[i] = new List<Int32>();
            }
        }

        // Add edge from v -> w
        public void AddEdge(int v, int w)
        {
            adj[v].Add(w);
        }

        // Print BFS  traversal
        // s -> start node
        // BFS uses a queue as a base
        void BFS(int s)
        {
            bool[] visited = new bool[vertices];

            // Create a queue for BFS
            Queue<int> queue = new Queue<int>();
            visited[s] = true;
            queue.Enqueue(s);

            // Loop through all nodes in queue
            while(queue.Count != 0)
            {
                // Dequeue a vertex from queue and print it
                s = queue.Dequeue();
                Console.WriteLine("next -> " + s);

                // Get all the adjacent vertices of s
                foreach(Int32 next in adj[s])
                {
                    if (!visited[next])
                    {
                        visited[next] = true;
                        queue.Enqueue(next);
                    }
                }
            }
        }

        // DFS traversal
        // DFS uses stack as a base
        public void DFS(int s)
        {
            bool[] visited = new bool[vertices];

            // For DFS uses stack
            Stack<int> stack = new Stack<int>();
            visited[s] = true;
            stack.Push(s);

            while(stack.Count != 0)
            {
                s = stack.Pop();
                Console.WriteLine("next -> " + s);
                foreach(int i in adj[s])
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        stack.Push(i);
                    }
                }
            }
        }

        public void PrintAdjacencyMatrix()
        {
            for(int i=0; i<vertices; i++)
            {
                Console.WriteLine(i + ":[");
                string s = "";
                foreach(var k in adj[i])
                {
                    s = s + (k + ",");
                }
                s = s.Substring(0, s.Length - 1);
                s = s + "]";
                Console.WriteLine(s);
                Console.WriteLine();
            }
        }

        // Calling Methods
        static void Main(string[] args)
        {
            clsGraph graph = new clsGraph(4);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 0);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 3);

            //Print adjacency matrix
            graph.PrintAdjacencyMatrix();

            Console.WriteLine("BFS traversal starting from vertex 2:");
            graph.BFS(2);
            Console.WriteLine("DFS traversal starting from vertex 2:");
            graph.DFS(2);
        }
    }
    
}
