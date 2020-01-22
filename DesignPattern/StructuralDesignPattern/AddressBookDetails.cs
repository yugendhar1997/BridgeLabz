// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBookDetails.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.StructuralDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is the interface for Address Book Details.
    /// </summary>
    public interface AddressBookDetails
    {
        /// <summary>
        /// method for Name instance.
        /// </summary>
        /// <returns></returns>
        public string name();

        /// <summary>
        /// Address instance.
        /// </summary>
        /// <returns></returns>
        public string address();

        /// <summary>
        /// State instance.
        /// </summary>
        /// <returns></returns>
        public string state();

        /// <summary>
        /// City instance.
        /// </summary>
        /// <returns></returns>
        public string city();

        /// <summary>
        /// Phone no instance.
        /// </summary>
        /// <returns></returns>
        public int phoneNo();

        /// <summary>
        /// Zipcode instance.
        /// </summary>
        /// <returns></returns>
        public int zipCode();
    }
}

