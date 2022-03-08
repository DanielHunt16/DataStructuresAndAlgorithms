using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuntingYardAlgorithm
{
    class ShuntingYardAlgorithm
    {
        public static string Evalulate(string val)
        {
            string output = string.Empty;
            bool loop;

            string[] input = val.Split(' ');
            StackADT<string> stack = new StackADT<string>(input.Length);


            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() == "(")
                {
                    stack.Push(input[i].ToString());
                }
                else if (input[i].ToString() == ")")
                {
                    loop = true;

                    while (loop)
                    {
                        if (stack.Peek() == "(")
                        {
                            stack.Pop();
                            loop = false;
                        }
                        else
                        {
                            output += stack.Pop();
                        }

                    }
                }
                else if (OperatorPrecedence(input[i].ToString()) == -1)
                {
                    output += input[i];
                }
                else
                {
                    loop = true;

                    while (loop)
                    {
                        if (stack.IsEmpty())
                        {
                            loop = false;
                        }
                        else if (stack.Peek() == "(")
                        {
                            loop = false;
                        }
                        else if (OperatorPrecedence(stack.Peek()) > OperatorPrecedence(input[i].ToString()))
                        {
                            output += stack.Pop();
                        }
                        else if (OperatorPrecedence(stack.Peek()) == OperatorPrecedence(input[i].ToString()) && Associativity(input[i].ToString()) == 'L')
                        {
                            output += stack.Pop();
                        }
                        else
                        {
                            loop = false;
                        }
                    }

                    stack.Push(input[i].ToString());
                }

            }

            while (!stack.IsEmpty())
            {
                output += stack.Pop();
            }


            return output;
        }

        private static int OperatorPrecedence(string input)
        {
            if (input == "^")
            {
                return 4;
            }
            else if (input == "*" || input == "/")
            {
                return 3;
            }
            else if (input == "+" || input == "-")
            {
                return 2;
            }
            else if (input == "(" || input == ")")
            {
                return 1;
            }

            return -1;
        }

        private static char Associativity(string input)
        {
            if (input == "^")
            {
                return 'R';
            }

            return 'L';
        }
    }
}
