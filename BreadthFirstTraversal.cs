using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreadthFirstTraversal
{
    class Program
    { 
        static void Main(string[] args)
        {
            DateTime start;
            Graph graph = new Graph(7);
            start = DateTime.Now;
            graph.AddEdges(0, 2);
            graph.AddEdges(0, 1);
            graph.AddEdges(2, 3);
            graph.AddEdges(2, 4);
            graph.AddEdges(3, 4);
            graph.AddEdges(4, 6);
            graph.AddEdges(3, 6);
            graph.AddEdges(1, 5);
            graph.AddEdges(5, 6);            

            Console.Write("The following is Breadth First Traversal (starting from vertex 0)\n");

            graph.BFS(0);
            Console.WriteLine();
            Console.WriteLine(DateTime.Now - start);
            Console.ReadLine();
            
        }       
        
    }

    public class Graph 
    {
        public int verticies;
        public LinkedList<int>[] adj;

        //Constructor
        public Graph(int verts)
        {
            adj = new LinkedList<int>[verts];
            for(int i = 0; i < adj.Length; i++)
            {
                adj[i] = new LinkedList<int>();
            }
            verticies = verts;
        }

        public void AddEdges(int v, int w)
        {
            adj[v].AddLast(w);
        }

        //Starts from a given source s 
        public void BFS(int s)
        {
            //Marks all the nodes as not visited
            bool[] visited = new bool[verticies];

            for (int i = 0; i < verticies; i++)
            {
                visited[i] = false;
            }

            LinkedList<int> queue = new LinkedList<int>();

            visited[s] = true;
            queue.AddLast(s);

            while (queue.Any())
            {
                s = queue.First();
                Console.Write(s + " ");
                queue.RemoveFirst();

                LinkedList<int> list = adj[s];

                foreach(var val in list)
                {
                    if (!visited[val])
                    {
                        visited[val] = true;
                        queue.AddLast(val);
                    }
                }
            }
        }
    }
}
