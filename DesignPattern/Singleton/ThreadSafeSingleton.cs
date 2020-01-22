// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ThreadSafeSingleton.cs" company="Bridgelabz">
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
    /// this class provide the thread safe solution in which multiple thread use same object
    /// </summary>
    public class ThreadSafeSingleton
    {
        /// <summary>
        /// this variable used to count object 
        /// </summary>
        private static int count = 0;

        /// <summary>
        /// initially object null which is static
        /// </summary>
        private static ThreadSafeSingleton singletonObject = null;

        /// <summary>
        /// create single object with read only keyword
        /// </summary>
        private static readonly Object ObjectLock = new Object();

        /// <summary>
        /// Gets the get singleton.
        /// </summary>
        /// <value>
        /// The get singleton.
        /// </value>
        public static ThreadSafeSingleton GetSingleton
        {
            get
            {
                //// here check the object is null
                if (singletonObject == null)
                {
                    ////provide the lock to avoid the other thread interaction
                    lock (ObjectLock)
                    {
                        if (singletonObject == null)
                        {
                            ////create the object here
                            singletonObject = new ThreadSafeSingleton();
                        }
                    }
                }

                ////return actual object
                return singletonObject;
            }
        }

        /// <summary>
        /// Prevents a default instance of the <see cref="ThreadSafeSingleton"/> class from being created.
        /// </summary>
        private ThreadSafeSingleton()
        {
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
