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
            public int Kaynak, Hedef, Weight;
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
                    int u = edges[j].Kaynak;
                    int v = edges[j].Hedef;
                    int weight = edges[j].Weight;

                    if (distance[u] != INFINITY && distance[u] + weight < distance[v])
                    {
                        distance[v] = distance[u] + weight;
                    }
                }
            }

            for (int i = 0; i < numberOfEdges; ++i)
            {
                int u = edges[i].Kaynak;
                int v = edges[i].Hedef;
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

                Console.WriteLine(i + " - " + distance[i]);
            }
        }

        public static void Main()
        {
            Edge[] edges = {
            //Kenarlar ve ağırlıkları belirliyoruz
            //Buradaki Weight'e maliyet denilebilir. ama tam tanımı bir kaynaktan bir hedefe mesafe ve maliyet toplamıdır.
            //örneğin A'dan B'ye kısa ama paralı bir yoldan gitmek uzun ama parasız bir yoldan gitmeye göre daha maliyetli olabilir.
            new Edge { Kaynak = 0, Hedef = 1, Weight = 1 },
            new Edge { Kaynak = 0, Hedef = 2, Weight = -4 },
            new Edge { Kaynak = 1, Hedef = 2, Weight = 3 },
            new Edge { Kaynak = 1, Hedef = 3, Weight = 2 },
            new Edge { Kaynak = 1, Hedef = 4, Weight = 2 },
            new Edge { Kaynak = 3, Hedef = 2, Weight = -5 },
            new Edge { Kaynak = 3, Hedef = 1, Weight = 1 },
            new Edge { Kaynak = 4, Hedef = 3, Weight = 3 }
        };

            //gidilmek istenen nokta sayısı 
            int numberOfVertices = 5;

            //gidilebilecek yol sayısı
            int numberOfEdges = 8;

            //başlangıç kaynak noktası
            int sourceVertex = 0;

            //fonksiyonumuzu çağırıyoruz
            BellmanFord(edges, numberOfEdges, numberOfVertices, sourceVertex);
            Console.ReadLine();
        }
    }
}
