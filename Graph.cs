namespace BellmanFord
{
    public class Graph
    {
        public int V, E; // Number of vertices and edges
        public Edge[] edges; // Array to store all edges

        public Graph(int v, int e)
        {
            V = v;
            E = e;
            edges = new Edge[E];
            for (int i = 0; i < e; ++i)
                edges[i] = new Edge();
        }

        // Utility function to print the solution
        private void Print(int[] distance)
        {
            Console.WriteLine("Vertex Distance from Source:");
            for (int i = 0; i < V; ++i)
                Console.WriteLine("{0}\t\t{1}", i, distance[i]);
        }
        // The main function to find the shortest distances from source to all other vertices using Bellman-Ford algorithm
        public void BellmanFordAlgorithm(int source)
        {
            int[] distance = new int[V];

            // Step 1: Initialize distances from source to all other vertices as INFINITE
            for (int i = 0; i < V; ++i)
                distance[i] = int.MaxValue;
            distance[source] = 0;

            // Step 2: Relax all edges |V| - 1 times. A simple shortest path from source to any other vertex can have at most |V| - 1 edges
            for (int i = 1; i < V; ++i)
            {
                foreach (Edge edge in edges)
                {
                    int u = edge.Source;
                    int v = edge.Destination;
                    int weight = edge.Weight;
                    if (distance[u] != int.MaxValue && distance[u] + weight < distance[v])
                        distance[v] = distance[u] + weight;
                }
            }

            // Step 3: Check for negative-weight cycles. The above step guarantees the shortest distances if the graph doesn't contain a negative-weight cycle. If we get a shorter path, then there is a cycle
            foreach (Edge edge in edges)
            {
                int u = edge.Source;
                int v = edge.Destination;
                int weight = edge.Weight;
                if (distance[u] != int.MaxValue && distance[u] + weight < distance[v])
                {
                    Console.WriteLine("Graph contains negative weight cycle");
                    return;
                }
            }

            Print(distance);
        }
    }
}
