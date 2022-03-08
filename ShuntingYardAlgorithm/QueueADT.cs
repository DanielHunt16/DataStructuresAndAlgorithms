using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuntingYardAlgorithm
{
    class QueueADT
    {
        public static int LastPTR { get; set; }
        public static int[] Arr { get; set; }

        public QueueADT(int size)
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
            for (int i = 0; i < Arr.Length - 1; i++)
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
}
