using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class HarmonicNumber
    {
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

        static double HarmonicValue(double number)
        {
            double value = 0.0;
            for (int i = 1; i < number; i++)
            {
                value = value + (i / number);
            }
            return value;
        }
    }
}
