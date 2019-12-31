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
        /// Powers the of two.
        /// </summary>
        public static void PowerOfTwo()
        {
            Console.WriteLine("Enter a Digit to Find Power Of 2 Which Should be Less than 32");
            int power = Convert.ToInt32(Console.ReadLine());

            while (power > 31)
            {
                Console.WriteLine("Integer Range OverFlowed");
                Console.WriteLine("Enter a Digit less than 32");
                power = Convert.ToInt32(Console.ReadLine());
            }

            Utility.CheckPower(power);
        }
    }
}
