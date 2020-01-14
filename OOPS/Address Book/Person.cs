// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Person.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OOPS.Address_Book
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Person Class is Like Model Class
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string[] Address 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        public string PhoneNumber 
        { 
            get; 
            set; 
        }
    }
}
