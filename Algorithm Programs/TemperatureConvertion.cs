// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TemperatureConvertion.cs" company="Bridgelabz">
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
    /// To Convert Given Temperature Fahrenheit to Celsius and Vice Versa
    /// </summary>
    public class TemperatureConvertion
    {
        /// <summary>
        /// The Fahrenheit , Celsius declared
        /// </summary>
       private int fahrenheit, celsius;

        /// <summary>
        /// Converts the temperature.
        /// </summary>
        public void ConvertTemperature()
        {
            Console.WriteLine("Press 1 : Celsius To Fahrenheit");
            Console.WriteLine("Press 2 : Fahrenheit To Celsius");

            int press = Convert.ToInt32(Console.ReadLine());
            switch (press)
            {
                case 1:
                    Console.WriteLine("Enter Temperature in Celsius");
                    this.celsius = Convert.ToInt32(Console.ReadLine());
                    this.fahrenheit = (this.celsius * 9 / 5) + 32;
                    Console.WriteLine("Given " + this.celsius + " °C celsius temperature in fahrenheit : " + this.fahrenheit + " °F");
                    break;
                case 2:
                    Console.WriteLine("Enter Temperature in Fahrenheit");
                    this.fahrenheit = Convert.ToInt32(Console.ReadLine());
                    this.celsius = (this.fahrenheit - 32) * 5 / 9;
                    Console.WriteLine("Given " + this.fahrenheit + " °Fahrenheit temperature in celcius : " + this.celsius + " °C");
                    break;
            }
        }
    }
}
