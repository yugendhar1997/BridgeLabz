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
        private static int count = 0;

        /// <summary>
        /// Sums the of numbers.
        /// </summary>
        public void SumOfNumbers()
        {
            Console.WriteLine("Enter No.Of Inputs To An Array");
            int input = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[input];
            Console.WriteLine("Enter " + input + " Values");
            for (int i = 0; i < input; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            ////Checking For Triplets By Loops
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length - 1; j++)
                {
                    for (int k = j + 1; k < array.Length - 1; k++)
                    {
                        if (array[i] + array[j] + array[k] == 0)
                        {
                            Console.WriteLine(array[i] + "+" + array[j] + "+" + array[k] + "=" + "0");
                            count++;
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Total No.Of Pairs Are : " + count);
        }
    }
}
