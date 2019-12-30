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
        public void GenerateCoupons()
        {
            Random random = new Random();
            Console.WriteLine("How many Distinct Coupon Codes Do you Want Generate?");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(input + " Distinct Coupon Codes are: ");
            for (int i = 1; i <= input; i++)
            {
                int num = random.Next(100000, 999999);
                Console.WriteLine(i + " : " + num);
            }
        }
    }
}
