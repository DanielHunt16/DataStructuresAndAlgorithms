using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalulatePostfix
{
    class Program
    {
        static void Main(string[] args)
        {         
            string input = "3 10 5 + *";

            Console.WriteLine(Evalulate(input));
            Console.ReadLine();
        }

        public static int Evalulate(string input)
        {
            StackADT<int> stack = new StackADT<int>(input.Length);

            string[] vals = input.Split(' ');

            for(int i = 0; i < vals.Length; i++)
            {
                if(Int32.TryParse(vals[i].ToString(), out int result))
                {
                    stack.Push(result);
                }
                else
                {
                    int num = Calculate(stack.Pop(), stack.Pop(), vals[i].ToString());
                    stack.Push(num);
                }
            }
            return stack.Pop();
        }

        public static int Calculate(int Operand1, int Operand2, string Operator)
        {
            if (Operator == "+")
            {
                return Operand2 + Operand1;
            }
            else if (Operator == "-")
            {
                return Operand2 - Operand1;
            }
            else if (Operator == "*")
            {
                return Operand2 * Operand1;
            }
            else if (Operator == "/")
            {
                return Operand2 / Operand1;
            }
            else if (Operator == "^")
            {
                return (int)Math.Pow(Operand2, Operand1);
            }
            else
            {
                return 0;
            }            
        }

    }
}
