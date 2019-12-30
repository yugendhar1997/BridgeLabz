// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MonthlyPayment.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Algorithm_Programs
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// To Detect Monthly Payments
    /// </summary>
    public class MonthlyPayment
    {
        /// <summary>
        /// Calculates the payment.
        /// </summary>
        public void CalculatePayment()
        {
            Console.WriteLine("Enter The Principle Amount");
            double principleAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Years to Pay Principle Amount");
            double years = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Rate Of Interest for Principle Amount");
            double rateOfInterest = Convert.ToInt32(Console.ReadLine());

            double n = 12 * years;
            double r = rateOfInterest / (12 * 100);

            double payment = (principleAmount * r) / (1 - Math.Pow(1 + r, -n));
            Console.WriteLine("Monthly Payment Rs :" + payment + "/-");
        }
    }
}
