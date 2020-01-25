// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SingletonLazy.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.Singleton
{
    using System;

    /// <summary>
    /// this is lazy class which create one object
    /// </summary>
    public class SingletonLazy
    {
        /// <summary>
        /// this is lazy object creation
        /// </summary>
        private static readonly Lazy<SingletonLazy> SingletonObject = new Lazy<SingletonLazy>(() => new SingletonLazy());

        /// <summary>
        /// this variable used to count object 
        /// </summary>
        private static int count = 0;

        /// <summary>
        /// Gets the get singleton.
        /// </summary>
        /// <value>
        /// The get singleton.
        /// </value>
        public static SingletonLazy GetSingleton
        {
            get
            {
                //// return object here
                return SingletonObject.Value;
            }
        }

        /// <summary>
        /// Prevents a default instance of the <see cref="SingletonLazy"/> class from being created.
        /// </summary>
        private SingletonLazy()
        {
            //// increament if multiple object created
            count++;
            Console.WriteLine("Number Of Object " + count);
        }

        /// <summary>
        /// this method display message on console
        /// </summary>
        /// <param name="message">it take message to print</param>
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}