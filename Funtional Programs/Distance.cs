// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Distance.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// To Find The Euclidean distance from the point (x, y) to the origin (0, 0)
    /// </summary>
    public class Distance
    {
        /// <summary>
        /// Finds the distance.
        /// </summary>
        public void FindDistance()
        {
            Console.WriteLine("Enter The X Value");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Y value");
            int y = Convert.ToInt32(Console.ReadLine());

            this.CalculateDistance(x, y);
        }

        /// <summary>
        /// Calculates the distance.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public void CalculateDistance(int x, int y)
        {
            Console.WriteLine();
            Console.WriteLine("Distance is " + Math.Sqrt((x * x) + (y * y)));
        }
    }
}
