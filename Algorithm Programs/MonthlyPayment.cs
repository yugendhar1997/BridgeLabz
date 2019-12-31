// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MonthlyPayment.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Algorithm_Programs
{
    using System;
    
    /// <summary>
    /// To Detect Monthly Payments
    /// </summary>
    public class MonthlyPayment
    {
        /// <summary>
        /// Calculates the payment.
        /// </summary>
        public static void CalculatePayment()
        {
            Console.WriteLine("Enter The Principle Amount");
            double principleAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Years to Pay Principle Amount");
            double years = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Rate Of Interest for Principle Amount");
            double rateOfInterest = Convert.ToInt32(Console.ReadLine());

            Utility.Payment(principleAmount, years, rateOfInterest);
        }
    }
}
