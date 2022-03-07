using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class Graph
    {
        public int[,] AdjMatrix { get; set; }
        private int NodeNum { get; set; }

        public Graph(int nodesAmount)
        {
            AdjMatrix = new int[nodesAmount, nodesAmount];
            NodeNum = nodesAmount;
        }

        public void SetUpGraph()
        {
            bool CorrectInput = false;
            for(int row = 0; row < NodeNum; row++)
            {
                for(int column = 0; column < NodeNum; column++)
                {
                    CorrectInput = false;
                    do
                    {
                        try
                        {
                            Console.WriteLine($"Distance of {Convert.ToChar(row+65)}->{Convert.ToChar(column + 65)}");
                            AdjMatrix[row, column] = Int32.Parse(Console.ReadLine());
                            CorrectInput = true;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.ReadLine();
                        }
                    } while (!CorrectInput);
                }
            }
        }

        public void OutputMatrix()
        {
            Console.Write("  ");
            for(int i = 65; i < NodeNum+65; i++)
            {
                Console.Write($"{Convert.ToChar(i)} ");
            }
            Console.WriteLine();

            for (int row = 0; row < NodeNum; row++)
            {
                Console.Write($"{Convert.ToChar(row + 65)} ");

                for (int column = 0; column < NodeNum; column++)
                {
                    Console.Write($"{AdjMatrix[row, column]} ");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
        
        public static string[] MinimumSpanningTree(int StartingNode, int[,] AdjMatrixPassed, int NodeNum)
        {
            int MST = 0;
            string[] arcs = new string[NodeNum];

            List<List<int>> AdjMatrix = new List<List<int>>();

            for(int i = 0; i < NodeNum; i++)
            {
                //AdjMatrix.Add(AdjMatrixPassed[i].ToList());               
            }

            return new string[5];
        }

    }
}
