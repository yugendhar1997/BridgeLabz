// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBookOperation.cs" company="Bridgelabz">
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
    /// This is the interface of AddressBookOperation.
    /// </summary>
    interface AddressBookOperation
    {
        /// <summary>
        /// method to Get the details.
        /// </summary>
        public void GetDetails();

        /// <summary>
        /// method to Add the item.
        /// </summary>
        public void AddItem();

        /// <summary>
        /// method to Update the file.
        /// </summary>
        public void UpdateFile();

        /// <summary>
        /// method to Delete the item.
        /// </summary>
        public void DeleteItem();
    }
}
