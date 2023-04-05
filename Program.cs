using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bellman_Ford_Algoritms
{
    internal class Program
    {
        public struct Edge
        {
            public int Source, Destination, Weight;
        };

        public static void BellmanFord(Edge[] edges, int numberOfEdges, int numberOfVertices, int sourceVertex)
        {
            int INFINITY = int.MaxValue;

            int[] distance = new int[numberOfVertices];
            for (int i = 0; i < numberOfVertices; ++i)
            {
                distance[i] = INFINITY;
            }

            distance[sourceVertex] = 0;

            for (int i = 1; i <= numberOfVertices - 1; ++i)
            {
                for (int j = 0; j < numberOfEdges; ++j)
                {
                    int u = edges[j].Source;
                    int v = edges[j].Destination;
                    int weight = edges[j].Weight;

                    if (distance[u] != INFINITY && distance[u] + weight < distance[v])
                    {
                        distance[v] = distance[u] + weight;
                    }
                }
            }

            for (int i = 0; i < numberOfEdges; ++i)
            {
                int u = edges[i].Source;
                int v = edges[i].Destination;
                int weight = edges[i].Weight;

                if (distance[u] != INFINITY && distance[u] + weight < distance[v])
                {
                    Console.WriteLine("Graf negatif döngü içeriyor.");
                    return;
                }
            }

            Console.WriteLine("Düğümlere olan en kısa mesafeler:");
            for (int i = 0; i < numberOfVertices; ++i)
            {
                Console.WriteLine("{0} - {1}", i, distance[i]);
            }
        }

        public static void Main()
        {
            Edge[] edges = {
            //Kenarlar ve ağırlıkları
            new Edge { Source = 0, Destination = 1, Weight = -1 },
            new Edge { Source = 0, Destination = 2, Weight = 4 },
            new Edge { Source = 1, Destination = 2, Weight = 3 },
            new Edge { Source = 1, Destination = 3, Weight = 2 },
            new Edge { Source = 1, Destination = 4, Weight = 2 },
            new Edge { Source = 3, Destination = 2, Weight = 5 },
            new Edge { Source = 3, Destination = 1, Weight = 1 },
            new Edge { Source = 4, Destination = 3, Weight = -3 }
        };

            int numberOfVertices = 5;
            int numberOfEdges = 8;

            int sourceVertex = 0;

            BellmanFord(edges, numberOfEdges, numberOfVertices, sourceVertex);
            Console.ReadLine    ();
        }
    }
}
