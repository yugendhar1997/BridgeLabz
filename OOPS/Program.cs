// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OOPS
{
    using OOPS.AddressBook;
    using System;

    /// <summary>
    /// Run Total Application
    /// </summary>
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Press 1 : Address Book");

                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        AddressBook.AddressBookOperations addressBookOperations = new AddressBook.AddressBookOperations();
                        addressBookOperations.AddressOperation();
                        break;
                }
            }
        }
    }
}
