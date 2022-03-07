using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(6);
            int[,] matrix = new int[,] { { 0, 4, 4, 0, 0, 0}, {4, 0, 2, 0, 0, 0 }, {4, 2, 0, 3, 2, 4 }, {0, 0, 3, 0, 0, 3 }, {0, 0, 2, 0, 0, 3 }, {0, 0, 4, 3, 3, 0 } };
            graph.AdjMatrix = matrix;
            //graph.SetUpGraph();

            graph.OutputMatrix();
        }
    }
}
