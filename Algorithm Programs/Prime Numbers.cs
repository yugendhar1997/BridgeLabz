// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Prime_Numbers.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Algorithm_Programs
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// To Find The Prime Numbers
    /// </summary>
    public class Prime_Numbers
    {
        ////initialie variables
        private int i, j, count;

        /// <summary>
        /// Checks the prime.
        /// </summary>
        public void CheckPrime()
        {
            Console.WriteLine("\nPrime Numbers b/w 0 - 1000");
            for (i = 0; i < 1000; i++)
            {
                count = 0;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        this.count++;
                    }
                }

                if (this.count == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
