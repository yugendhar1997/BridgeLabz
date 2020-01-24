// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAddressBookDetails.cs" company="Bridgelabz">
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
    public interface IAddressBookDetails
    {
        /// <summary>
        /// method for Name instance.
        /// </summary>
        /// <returns>The Name</returns>
        public string Name();

        /// <summary>
        /// Address instance.
        /// </summary>
        /// <returns>The Address</returns>
        public string Address();

        /// <summary>
        /// State instance.
        /// </summary>
        /// <returns>The State</returns>
        public string State();

        /// <summary>
        /// City instance.
        /// </summary>
        /// <returns>The City</returns>
        public string City();

        /// <summary>
        /// Phone no instance.
        /// </summary>
        /// <returns>The Phone Number</returns>
        public int PhoneNo();

        /// <summary>
        /// Zip code instance.
        /// </summary>
        /// <returns>The Zip code</returns>
        public int ZipCode();
    }
}