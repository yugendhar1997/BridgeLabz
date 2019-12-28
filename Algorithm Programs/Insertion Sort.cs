using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class Insertion_Sort
    {
        public void PerformInsertionSort()
        {
            
            Console.WriteLine("Enter The Array Size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            Console.WriteLine("Enter An Array Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("The Array is :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Sort(arr, arr.Length);

            Console.WriteLine("The Sorted Array is :");
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }

        public void Sort(int[] data, int n)
        {
            int i, j;
            for (i = 1; i < n; i++)
            {
                int item = data[i];
                int ins = 0;
                for (j = i - 1; j >= 0 && ins != 1;)
                {
                    if (item < data[j])
                    {
                        data[j + 1] = data[j];
                        j--;
                        data[j + 1] = item;
                    }
                    else ins = 1;
                }
            }
        }
    }
}