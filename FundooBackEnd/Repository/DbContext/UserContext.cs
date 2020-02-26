// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserContext.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
using Microsoft.EntityFrameworkCore;
using Model;
using Model.LabelModel;
using Model.NotesModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    /// <summary>
    /// User Context 
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class UserContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public UserContext(DbContextOptions<UserContext> options): base(options)
        {
        }

        /// <summary>
        /// Gets or sets the user data.
        /// </summary>
        /// <value>
        /// The user data.
        /// </value>
        public DbSet<UserModels> UserData { get; set; }

        public DbSet<NotesModel> Notes { get; set; }

        public DbSet<LabelModel> Labels { get; set; }
    }
}
