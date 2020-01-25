// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FactoryClient.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.CreationalPattern
{
    using System;

    /// <summary>
    /// this is client Factory class which has client requirement method that provide the choice to user 
    /// to take a particular product at run time. 
    /// </summary>
    public class FactoryClient
    {
        /// <summary>
        /// Clients the requirement.
        /// </summary>
        public static void ClientRequirement()
        {
            ConcreateFactory concreateFactory = new ConcreateFactory();
            Console.WriteLine("Available Product : PC\tLaptop\tServer ");
            Console.WriteLine("Which Product You Want ");
            string productName = Console.ReadLine();
            try
            {
                IComputer computer = concreateFactory.GetUserDecidedConfiguration(productName);
                if (computer == null)
                {
                    Console.WriteLine("Your Product Not Made in this Factory");
                }

                computer.GetConfiguration();
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}
