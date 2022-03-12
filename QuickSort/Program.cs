// Uses Lomuto's Partion scheme 
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
            int[] a;
            
            Random random = new Random();

            int length = random.Next(1, int.MaxValue/1000);
            a = new int[length];

            for(int i = 0; i < length; i++)
            {
                a[i] = random.Next(1, int.MaxValue);
            }
            
            
            Sort sort = new Sort(a);

            sort.quickSort(0, a.Length - 1);            

            for (int i = 0; i < sort.A.Length; i++)
            {
                if (i == sort.A.Length - 1)
                {
                    Console.Write($"{sort.A[i]}");
                }
                else
                {
                    Console.Write($"{sort.A[i]}, ");
                }

            }

            Console.ReadLine();
        }
    }    

    class Sort 
    { 

        public int[] A { get; set; }

        public Sort(int[] arrayIn)
        {
            A = arrayIn;
        }

        public void quickSort(int low, int high)
        {
            int partitionIndex;

            if(low < high)
            {
                partitionIndex = partition(low, high);

                quickSort(low, partitionIndex - 1);
                quickSort(partitionIndex + 1, high);
            }
        }

        public int partition(int low, int high)
        {
            int pivot = A[high];
            int i = low - 1;
            int temp;

            for(int j = low; j <= high-1; j++)
            {
                if(A[j] < pivot)
                {
                    i++;
                    temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                }
            }

            temp = A[i + 1];
            A[i + 1] = A[high];
            A[high] = temp;

            return i + 1;
        }

    }

}
