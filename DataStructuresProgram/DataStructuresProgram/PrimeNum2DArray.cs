// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeNum2DArray.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructuresProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is the class for prime number printing.
    /// </summary>
    public class PrimeNum2DArray
    {

        /// <summary>
        /// Prime Number using 2d Array.
        /// </summary>
        public static void primeArray()
        {
            Utility li = new Utility();
            int limit = 1000;
            int i, j, count;
            Console.WriteLine("Only Prime Number ...............");
            for (i = 1; i < limit; i++)
            {
                count = 0;
                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    li.Make2Dmatrix(i);
                }
            }
            li.show();
        }
    }
}
