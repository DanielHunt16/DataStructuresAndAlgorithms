using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksADT
{
    public class Stack<T>
    {
        private static T[] Arr { get;  set;}
        private static int topVal { get; set; }
        
        public Stack(int size)
        {
            Arr = new T[size];
            topVal = -1;
        }

        public void Push(T val)
        {
            topVal++;
            Arr[topVal] = val;
        }

        public T Pop()
        {
            T ReturnVal = Arr[topVal];
            topVal--;            
            return ReturnVal;
        }

        public T Peek()
        {
            return Arr[topVal];
        }

        public bool IsFull()
        {            
            return topVal == Arr.Length-1;
        }

        public bool IsEmpty()
        {
            return topVal == -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>(5);

            Console.WriteLine(stack.IsEmpty());

            for(int i = 65; i < 69; i++)
            {
                stack.Push((char) i);
            }

            Console.WriteLine(stack.IsFull());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.ReadLine();

        }
    }
}
