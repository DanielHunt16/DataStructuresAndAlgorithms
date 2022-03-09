using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] a = {1, 2, 3 ,5, 7, 8, 4, 6 }; 

            QuickSort quickSort = new QuickSort(a);

            quickSort.Quicksort(0, a.Length - 1);

            for(int i = 0; i < quickSort.A.Length; i++)
            {
                if (i == quickSort.A.Length - 1)
                {
                    Console.Write($"{quickSort.A[i]}");
                }
                else
                {
                    Console.Write($"{quickSort.A[i]}, ");
                }
                
            }

            Console.ReadLine();
        }
    }

    class QuickSort
    {    
        public int[] A { get; set; }

        public QuickSort(int[] a)
        {
            A = a;
        }

        public int Quicksort(int lo, int hi)
        {
            if( lo >= hi || lo < 0)
            {
                return -1;
            }

            int p = Partition( lo, hi);

            Quicksort( lo, p - 1);
            Quicksort( p + 1, hi);

            return 1;
        }

        private int Partition ( int lo, int hi)
        {
            int pivot = A[hi];
            int i;
            int temp;

            i = lo - 1;

            for(int j = lo; j < hi-1; j++)
            {
                if(A[j] <= pivot)
                {
                    i++;
                }

                temp = A[j];
                A[j] = A[i];
                A[i] = temp;
            }

            i++;

            temp = A[hi];
            A[hi] = A[i];
            A[i] = temp;

            return i;
        }

    }

}
