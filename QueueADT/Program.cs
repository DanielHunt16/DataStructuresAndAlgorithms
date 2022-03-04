using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueADT
{
    class Queue 
    {

        public static int LastPTR { get; set; }
        public static int[] Arr { get; set; }

        public Queue(int size)
        {
            Arr = new int[size];
            LastPTR = -1;
        }

        public void Enqueue(int val)
        {
            LastPTR++;
            Arr[LastPTR] = val;
        }

        public int Dequeue()
        {
            int ReturnVal = Arr[0];
            LastPTR--;
            for(int i = 0; i < Arr.Length-1; i++)
            {
                Arr[i] = Arr[i + 1];
            }

            return ReturnVal;
        }

        public int Peek()
        {
            return Arr[0];
        }

        public bool IsEmpty()
        {
            return LastPTR == -1;
        }

        public bool IsFull()
        {
            return LastPTR == Arr.Length - 1;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Queue queue1 = new Queue(5);

            Console.WriteLine(queue1.IsEmpty());
            for(int i = 0; i < 4; i++)
            {
                queue1.Enqueue(i);
            }

            Console.WriteLine(queue1.Dequeue());
            Console.WriteLine(queue1.Dequeue());

            queue1.Enqueue(44);
            queue1.Enqueue(686);
            queue1.Enqueue(65);

            Console.WriteLine(queue1.IsFull());

            Console.ReadLine();
        }
    }
}
