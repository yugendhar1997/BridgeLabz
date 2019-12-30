// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HarmonicNumber.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// To Find The Nth Harmonic Number
    /// </summary>
    public class HarmonicNumber
    {
        /// <summary>
        /// Harmonics the value.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>Double Number</returns>
        public static double HarmonicValue(double number)
        {
            double value = 0.0;
            for (int i = 1; i < number; i++)
            {
                value = value + (i / number);
            }
            ////returns value of Nth Harmonic
            return value;
        }

        /// <summary>
        /// Finds the harmonic number.
        /// </summary>
        public void FindHarmonicNumber()
        {
            Console.WriteLine("Enter a Number to Find Harmonic Value");
            double number = Convert.ToDouble(Console.ReadLine());
            double output = HarmonicValue(number);

            if (number > 0)
            {
                Console.WriteLine();
                Console.WriteLine(number + "th Harmonic Value is " + output);
            }
            else
            {
                Console.WriteLine("Entered Number Should be GreatThan ZERO");
            }
        }
    }
}
