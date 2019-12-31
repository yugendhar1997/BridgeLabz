// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LeapYear.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// Checks The Given Number Leap Year or Not
    /// </summary>
    public class LeapYear
    {
        /// <summary>
        /// Checks the LeapYear
        /// </summary>
        public static void CheckLeapYear()
        {
            Console.WriteLine("Enter a 4 digit Year to Check Leap Year or Not");
            int year = Convert.ToInt32(Console.ReadLine());

            ////While For BlockOut invalid values Given By User
            while (year < 999 || year > 9999)
            {
                Console.WriteLine("Year must be  4 digits");
                Console.WriteLine("Enter a year in 4 Digits");
                year = Convert.ToInt32(Console.ReadLine());
            }

            // Calling the isLeap Function from Utility Class
            if (Utility.IsLeap(year))
            {
                Console.WriteLine();
                Console.WriteLine(year + " is Leap Year");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(year + " is not Leap Year");
            }
        }
    }
}
