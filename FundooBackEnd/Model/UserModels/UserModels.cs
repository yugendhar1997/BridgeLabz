// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserModels.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    /// <summary>
    /// User Models Class
    /// </summary>
    public class UserModels 
    {
        /// <summary>
        /// The first name
        /// </summary>
        private string firstName;
        public string FirstName
        {
            set
            {
                firstName = value;
            }
            get
            {
                return firstName;
            }
        }

        /// <summary>
        /// The last name
        /// </summary>
        private string lastName;
        public string LastName
        {
            set
            {
                lastName = value;
            }
            get
            {
                return lastName;
            }
        }

        /// <summary>
        /// The password
        /// </summary>
        private string password;
        public string Password
        {
            set
            {
                password = value;
            }
            get
            {
                return this.password;
            }
        }

        /// <summary>
        /// The email
        /// </summary>
        private string email;
        [Key]
        public string Email
        {
            set
            {
                email = value;
            }
            get
            {
                return email;
            }
        }
    }
}
