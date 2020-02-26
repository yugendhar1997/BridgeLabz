// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ForgetPasswordModel.cs" company="Bridgelabz">
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
    /// Forgot Password
    /// </summary>
    public class ForgetPasswordModel
    {
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [EmailAddress]
        [Required]
        public string Email
        {
            get;
            set;
        }
    }
}
