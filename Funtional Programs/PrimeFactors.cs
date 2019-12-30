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
        /// Factors the specified number.
        /// </summary>
        /// <param name="number">The number.</param>
        public static void Factors(int number)
        {
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    if (IsPrime(i))
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }

        /// <summary>
        /// Determines whether the specified number is prime.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>
        ///   <c>true</c> if the specified number is prime; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Primes the factor.
        /// </summary>
        public void PrimeFactor()
        {
            Console.WriteLine("Enter A Number To Find the Prime Factors");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Prime Factors are :");
            Factors(number);
        }
    }
}
