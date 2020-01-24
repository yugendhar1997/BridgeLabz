// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProxyDesignPattern.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.StructuralDesignPattern
{
    using System;

    /// <summary>
    /// This is the class for Proxy Design Pattern.
    /// </summary>
    public class ProxyDesignPattern
    {
        /// <summary>
        /// method for ATM withdrawal.
        /// </summary>
        public static void AtmWithdrawal()
        {
            Customer customer = new Customer();
            Console.WriteLine("Enter Available Balance");
            Customer.AvailableBalance = Convert.ToDouble(Console.ReadLine());

            AtmProxy atmProxy = new AtmProxy();
            Console.WriteLine("ATM Object Performing Operation");
            Console.WriteLine("Available Balance After Withdrawal : " + atmProxy.WithdrawCash());
        }
    }
}
