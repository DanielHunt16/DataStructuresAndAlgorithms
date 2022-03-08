using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalulatePostfix
{
    class StackADT<T>
    {
        private static T[] Arr { get; set; }
        private static int topVal { get; set; }

        public StackADT(int size)
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
            return topVal == Arr.Length - 1;
        }

        public bool IsEmpty()
        {
            return topVal == -1;
        }
    }
}
