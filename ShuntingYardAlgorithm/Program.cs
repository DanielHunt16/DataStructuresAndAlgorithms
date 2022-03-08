using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuntingYardAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "3 + 4 * 2 / ( 1 - 5 ) ^ 2 ^ 3";

            Console.WriteLine(ShuntingYardAlgorithm.Evalulate(input));           
            Console.ReadLine();
        }
        
    }
}
