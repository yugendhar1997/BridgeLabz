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
        public void FindWindChill()
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
                this.CalculateWind(temperature, speed);
            }
        }

        /// <summary>
        /// Calculates the wind.
        /// </summary>
        /// <param name="temperature">The temperature.</param>
        /// <param name="speed">The speed.</param>
        public void CalculateWind(double temperature, double speed)
        {
            double wind = (35.74 + 0.62158 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(speed, 0.16));
            Console.WriteLine();
            Console.WriteLine("Wind Chill : " + wind);
        }
    }
}
