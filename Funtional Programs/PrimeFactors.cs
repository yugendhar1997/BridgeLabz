// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeFactors.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// Detects The Prime Factors Of a Given Number
    /// </summary>
    public class PrimeFactors
    {
        /// <summary>
        /// Primes the factor.
        /// </summary>
        public static void PrimeFactor()
        {
            Console.WriteLine("Enter A Number To Find the Prime Factors");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Prime Factors are :");
            Utility.Factors(number);
        }
    }
}
