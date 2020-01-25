// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
    using DesignPatterns.BehavioralDesignPattern;
    using DesignPatterns.CreationalPattern;
    using DesignPatterns.Singleton;
    using DesignPatterns.StructuralDesignPattern;

    /// <summary>
    /// This is main class of Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            string repeat;
            try
            {
                do
                {
                    Console.WriteLine("\nEnter Your Choice:");
                    Console.WriteLine("Press 1 : Singleton Operations");
                    Console.WriteLine("Press 2 : Factory Method Design Pattern");
                    Console.WriteLine("Press 3 : Cloning Operation Using Prototype Design Pattern");
                    Console.WriteLine("Press 4 : Vendor Adapter ");
                    Console.WriteLine("Press 5 : ATM Money Withdraw Proxy Design Pattern");
                    Console.WriteLine("Press 6 : Observer Design Pattern");
                    Console.WriteLine("Press 7 : Chat Mediator Design Pattern ");
                    Console.WriteLine("Press 8 : Shopping ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            SingletonOperations.SingletonType();
                            break;
                        case 2:
                            FactoryClient.ClientRequirement();
                            break;
                        case 3:
                            Cloning.CloningOperation();
                            break;
                        case 4:
                            Utility.VendorAdapterProgram();
                            break;
                        case 5:
                            ProxyDesignPattern.AtmWithdrawal();
                            break;
                        case 6:
                            Utility.ObserverProgram();
                            break;
                        case 7:
                            Utility.ChatMediatorProgram();
                            break;
                        case 8:
                            Utility.Shopping();
                            break;
                    }

                    Console.WriteLine("\nDo You want To Continue the Press 'Yes' Or 'No' ");
                    repeat = Console.ReadLine().ToLower();
                }
                while (repeat == "yes");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}