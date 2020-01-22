// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BillPughSingleton.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.Singleton
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Singleton of Bill Pugh Implementation
    /// </summary>
    public class BillPughSingleton
    {
        /// <summary>
        /// Prevents a default instance of the <see cref="BillPughSingleton"/> class from being created.
        /// </summary>
        private BillPughSingleton() { }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <returns>instance of Bill Pugh Object</returns>
        public static BillPughSingleton GetInstance()
        {
            return SingletonHelper.BillPughObject;
        }

        /// <summary>
        /// Singleton Helper Inner Class
        /// </summary>
        private static class SingletonHelper
        {
            /// <summary>
            /// The bill pugh object
            /// </summary>
            public static readonly BillPughSingleton BillPughObject = new BillPughSingleton();
        }
    }
}
