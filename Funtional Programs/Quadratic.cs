using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Quadratic
    {
        public void Quadratics()
        {
            Console.WriteLine("Enter a Value");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b Value");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter c Value");
            int c = Convert.ToInt32(Console.ReadLine());

            double delta = b * b - 4 * a * c;

            double Root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double Root2 = (-b - Math.Sqrt(delta)) / (2 * a);

            if (delta == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Roots are Real and Equal " + " &\nRoot 1 :" + Root1 + "\nRoot 2 :" + Root2);
            }
            else if (delta > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Roots are Real and Unequal " + "&\nRoot 1 :" + Root1 + "\nRoot 2 :" + Root2);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Roots are Imaginary and Unequal " + " &\nRoot 1 :" + Root1 + "\nRoot 2 :" + Root2);
            }
        }
    }
}
