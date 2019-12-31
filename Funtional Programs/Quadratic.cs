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
        public static void Quadratics()
        {
            Console.WriteLine("Enter a Value");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b Value");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter c Value");
            int c = Convert.ToInt32(Console.ReadLine());

            Utility.FindRoots(a, b, c);
        }
    }
}
