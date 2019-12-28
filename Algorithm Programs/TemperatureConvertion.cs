using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{

    class TemperatureConvertion
    {
        int fahrenheit, celsius;
        public void ConvertTemperature()
        {
            Console.WriteLine("Press 1 : Celsius To Fahrenheit");
            Console.WriteLine("Press 2 : Fahrenheit To Celsius");

            int press = Convert.ToInt32(Console.ReadLine());
            switch (press)
            {
                case 1:
                    Console.WriteLine("Enter Temperature in Celsius");
                    celsius = Convert.ToInt32(Console.ReadLine());
                    fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine("Given " + celsius + " °C celsius temperature in fahrenheit : " + fahrenheit + " °F");
                    break;

                case 2:
                    Console.WriteLine("Enter Temperature in Fahrenheit");
                    fahrenheit = Convert.ToInt32(Console.ReadLine());
                    celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine("Given " + fahrenheit + " °Fahrenheit temperature in celcius : " + celsius + " °C");
                    break;
            }
        }
    }
}
