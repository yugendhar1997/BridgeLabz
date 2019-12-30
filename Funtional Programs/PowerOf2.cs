// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PowerOf2.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// Finds The Power Of 2
    /// </summary>
    public class PowerOf2
    {
        /// <summary>
        /// Checks the power.
        /// </summary>
        /// <param name="power">The power.</param>
        public static void CheckPower(int power)
        {
            int value = 1;

            for (int i = 1; i <= power; i++)
            {
                value = value * 2;
                Console.WriteLine();
                Console.WriteLine(value);
            }
        }

        /// <summary>
        /// Powers the of two.
        /// </summary>
        public void PowerOfTwo()
        {
            Console.WriteLine("Enter a Digit to Find Power Of 2 Which Should be Less than 32");
            int power = Convert.ToInt32(Console.ReadLine());

            while (power > 31)
            {
                Console.WriteLine("Integer Range OverFlowed");
                Console.WriteLine("Enter a Digit less than 32");
                power = Convert.ToInt32(Console.ReadLine());
            }
            
            CheckPower(power);
        }
    }
}
