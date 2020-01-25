// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReflectionCompany.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.Singleton
{
    using System;

    /// <summary>
    /// Reflection Company
    /// </summary>
    public class ReflectionCompany
    {
        /// <summary>
        /// Gets or sets the name of the company.
        /// </summary>
        /// <value>
        /// The name of the company.
        /// </value>
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the company establish year.
        /// </summary>
        /// <value>
        /// The company establish year.
        /// </value>
        public int CompanyEstablishYear { get; set; }

        /// <summary>
        /// Gets or sets the number of employee.
        /// </summary>
        /// <value>
        /// The number of employee.
        /// </value>
        public int NumberOfEmployee { get; set; }

        /// <summary>
        /// Gets or sets the turn over.
        /// </summary>
        /// <value>
        /// The turn over.
        /// </value>
        public double TurnOver { get; set; }

        /// <summary>
        /// Company the details.
        /// </summary>
        public void CompanyDetails()
        {
            //// this line print details
            Console.WriteLine("Company Name : " + this.CompanyName + "\nCompany Establish Year : " + this.CompanyEstablishYear + "\nEmployee : " + this.NumberOfEmployee + "\nYearly TurnOver : " + this.TurnOver);
        }
    }
}
