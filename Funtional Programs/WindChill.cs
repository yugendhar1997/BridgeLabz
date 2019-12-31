// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WindChill.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// Finds Wind Chill
    /// </summary>
    public class WindChill
    {
        /// <summary>
        /// Finds the wind chill.
        /// </summary>
        public static void FindWindChill()
        {
            Console.WriteLine("Enter Temperature in Fahrenheit");
            double temperature = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Wind Speed in Miles per Hour");
            double speed = Convert.ToInt32(Console.ReadLine());

            if (Math.Abs(temperature) > 50 || speed > 120 || speed < 3)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid Input");
                Console.WriteLine("Temperature Should be lessthan 50°F & Speed Should b/w 3 mph to 120 mph");
            }
            else
            {
                Utility.CalculateWind(temperature, speed);
            }
        }
    }
}
