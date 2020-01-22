// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EagerInitialization.cs" company="Bridgelabz">
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
    /// Eager class creates only one object
    /// </summary>
    public class EagerInitialization
    {
        /// <summary>
        /// The singleton object
        /// </summary>
        private static readonly EagerInitialization SingletonObject = new EagerInitialization();

        /// <summary>
        /// The count
        /// </summary>
        private int count = 0;

        /// <summary>
        /// Prevents a default instance of the <see cref="EagerInitialization"/> class from being created.
        /// </summary>
        private EagerInitialization()
        {
            this.count++;
            Console.WriteLine("Number Of Object : " + this.count);
        }

        /// <summary>
        /// Gets the get singleton.
        /// </summary>
        /// <value>
        /// The get singleton.
        /// </value>
        public static EagerInitialization GetSingleton
        {
            get
            {
                return SingletonObject;
            }
        }

        /// <summary>
        /// Messages the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
