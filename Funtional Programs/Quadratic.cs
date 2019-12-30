// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Quadratic.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// Finds Quadratic Roots Of An Expression
    /// </summary>
    public class Quadratic
    {
        /// <summary>
        /// Quadratics this instance.
        /// </summary>
        public void Quadratics()
        {
            Console.WriteLine("Enter a Value");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b Value");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter c Value");
            int c = Convert.ToInt32(Console.ReadLine());

            double delta = (b * b) - (4 * a * c);

            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);

            if (delta == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Roots are Real and Equal " + " &\nRoot 1 :" + root1 + "\nRoot 2 :" + root2);
            }
            else if (delta > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Roots are Real and Unequal " + "&\nRoot 1 :" + root1 + "\nRoot 2 :" + root2);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Roots are Imaginary and Unequal " + " &\nRoot 1 :" + root1 + "\nRoot 2 :" + root2);
            }
        }
    }
}
