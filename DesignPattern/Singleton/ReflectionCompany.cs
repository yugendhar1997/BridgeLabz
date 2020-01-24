// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReflectionCompany.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Singleton
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Reflection Company
    /// </summary>
    public class ReflectionCompany
    {
        /// <summary>
        /// this variable hold name of company
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// this variable hold establish year of company
        /// </summary>
        public int CompanyEstablishYear { get; set; }

        /// <summary>
        /// this variable hold number of employee of company
        /// </summary>
        public int NumberOfEmployee { get; set; }

        /// <summary>
        /// this variable hold turn over of company
        /// </summary>
        public double TurnOver { get; set; }

        /// <summary>
        /// this method print the details of company on console
        /// </summary>
        public void ComapanyDetails()
        {
            //// this line print details
            Console.WriteLine("Company Name : {0}\tCompany Establish Year : {1}\tTotal Employee : {2}\tYearly TurnOver : {3}", this.CompanyName,
               this.CompanyEstablishYear, this.NumberOfEmployee, this.TurnOver);
        }
    }
}
