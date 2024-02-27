
using BellmanFord;

int V = 5; // Number of vertices in the graph
int E = 8; // Number of edges in the graph

Graph graph = new Graph(V, E);

// Example graph
graph.edges[0].Source = 0;
graph.edges[0].Destination = 1;
graph.edges[0].Weight = -1;

graph.edges[1].Source = 0;
graph.edges[1].Destination = 2;
graph.edges[1].Weight = 4;

graph.edges[2].Source = 1;
graph.edges[2].Destination = 2;
graph.edges[2].Weight = 3;

graph.edges[3].Source = 1;
graph.edges[3].Destination = 3;
graph.edges[3].Weight = 2;

graph.edges[4].Source = 1;
graph.edges[4].Destination = 4;
graph.edges[4].Weight = 2;

graph.edges[5].Source = 3;
graph.edges[5].Destination = 2;
graph.edges[5].Weight = 5;

graph.edges[6].Source = 3;
graph.edges[6].Destination = 1;
graph.edges[6].Weight = 1;

graph.edges[7].Source = 4;
graph.edges[7].Destination = 3;
graph.edges[7].Weight = -3;

int source = 0; // Source vertex

Console.WriteLine("Bellman-Ford algorithm results:");
graph.BellmanFordAlgorithm(source);
