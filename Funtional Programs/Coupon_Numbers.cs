// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Coupon_Numbers.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// Generate Coupon Codes
    /// </summary>
    public class Coupon_Numbers
    {
        /// <summary>
        /// Generates the coupons.
        /// </summary>
        public static void GenerateCoupons()
        {
            Console.WriteLine("How many Distinct Coupon Codes Do you Want Generate?");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(input + " Distinct Coupon Codes are: ");

            Utility.Coupons(input);
        }
    }
}
