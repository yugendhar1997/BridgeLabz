// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MergeSorting.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Algorithm_Programs
{
    using System;

    /// <summary>
    /// Performs Merge Sort
    /// </summary>
    public class MergeSorting
    {
        /// <summary>
        /// Sorting this instance.
        /// </summary>
        public static void Merge()
        {
            Console.Write("\nProgram for sorting a numeric array using Merge Sorting");
            Console.Write("\n\nEnter number of elements: ");
            int max = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[max];
            for (int i = 0; i < max; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("MergeSort By Recursive Method");
            Utility.SortMerge(numbers, 0, max - 1);

            for (int i = 0; i < max; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadLine();
        }
    }
}
