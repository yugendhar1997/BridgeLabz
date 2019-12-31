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
        /// Finds the harmonic number.
        /// </summary>
        public static void FindHarmonicNumber()
        {
            Console.WriteLine("Enter a Number to Find Harmonic Value");
            double number = Convert.ToDouble(Console.ReadLine());
            double output = Utility.HarmonicValue(number);

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
