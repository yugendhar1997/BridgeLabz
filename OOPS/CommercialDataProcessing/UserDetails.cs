// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserDetails.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OOPS.CommercialDataProcessing
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Details of User
    /// </summary>
    public class UserDetails
    {
        /// <summary>
        /// this variable hold the account holder name 
        /// </summary>
        public string accountHolderName;

        /// <summary>
        /// this variable hold the total balance of account holder.
        /// </summary>
        public double totalAmountAccountHolder;

        /// <summary>
        /// this variable hold the total share buy by user and initially it is zero.
        /// </summary>
        public int noOfShareBuyUser = 0;

        /// <summary>
        /// this method take all user detail which required to create account.
        /// </summary>
        /// <value>
        /// The name of the account holder.
        /// </value>
        public string AccountHolderName
        {
            get
            {
                return accountHolderName;
            } 

            set
            {
                accountHolderName = value;
            }
        }

        /// <summary>
        /// Uses the get input.
        /// </summary>
        public void UseGetInput()
        {
            ////here user enter user name
            Console.WriteLine("Enter Account Holder UserName");
            accountHolderName = Console.ReadLine();

            ////here user initial balance enter by user
            Console.WriteLine("How Many Doller Do You Have (Total Amount)");
            totalAmountAccountHolder = Convert.ToInt32(Console.ReadLine());
        }
    }
}
