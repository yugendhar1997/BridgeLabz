using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class Bubble_Sort
    {
        public void Sort()
        {
            int temp;
            Console.WriteLine("Enter The Size Of An Array");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];
            Console.WriteLine("Enter Array Elements");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("Before Sorting The Array : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }

            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
            Console.WriteLine("\nAfter Sorting The Array : ");
            foreach (int sort in array)
                Console.Write(sort+ " ");
        }

    }
    
}
