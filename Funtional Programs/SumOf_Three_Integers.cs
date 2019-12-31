// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SumOf_Three_Integers.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// Find Sum of Three integer
    /// </summary>
    public class SumOf_Three_Integers
    {
        /// <summary>
        /// The count
        /// </summary>
        public static int Count = 0;

        /// <summary>
        /// Sums the of numbers.
        /// </summary>
        public static void SumOfNumbers()
        {
            Console.WriteLine("Enter No.Of Inputs To An Array");
            int input = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[input];

            Console.WriteLine("Enter " + input + " Values");
            for (int i = 0; i < input; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Utility.FindTriplets(array);
        }
    }
}
