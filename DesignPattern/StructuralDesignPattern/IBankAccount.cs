// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IBankAccount.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
namespace DesignPatterns.StructuralDesignPattern
{
    using System;

    /// <summary>
    /// Bank Account Interface
    /// </summary>
    public interface IBankAccount
    {
        /// <summary>
        /// this is abstract method
        /// </summary>
        /// <returns> it return available balance</returns>
        public double WithdrawCash();
    }

    /// <summary>
    /// this is customer class implemented from bank account
    /// </summary>
    public class Customer : IBankAccount
    {
        /// <summary>
        /// Gets or sets the available balance.
        /// </summary>
        /// <value>
        /// The available balance.
        /// </value>
        public static double AvailableBalance { get; set; }

        /// <summary>
        /// this is withdrawal method
        /// </summary>
        /// <returns>it return available balance</returns>
        public double WithdrawCash()
        {
            Console.WriteLine("Enter Cash To Withdraw ");
            double cashWithdraw = Convert.ToDouble(Console.ReadLine());

            if (AvailableBalance > cashWithdraw)
            {
                AvailableBalance = AvailableBalance - cashWithdraw;
                return AvailableBalance;
            }
            else
            {
                Console.WriteLine("Enter valid cash");
                cashWithdraw = Convert.ToDouble(Console.ReadLine());
                AvailableBalance = AvailableBalance - cashWithdraw;
                return AvailableBalance;
            }
        }
    }

    /// <summary>
    /// ATM Proxy class Implements Bank Account Interface
    /// </summary>
    /// <seealso cref="DesignPatterns.StructuralDesignPattern.IBankAccount" />
    public class AtmProxy : IBankAccount
    {
        /// <summary>
        /// this method override 
        /// </summary>
        /// <returns>it return available balance</returns>
        public double WithdrawCash()
        {
            Customer customer = new Customer();
            return customer.WithdrawCash();
        }
    }
}
