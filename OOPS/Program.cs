// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OOPS
{
    using System;
    using OOPS.AddressBook;
    using OOPS.InventoryManagement;

    /// <summary>
    /// Run Total Application
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

            do
            {
                Console.WriteLine(" Press 1 : Address Book");
                Console.WriteLine(" Press 2 : Inventory Data");
                Console.WriteLine(" Press 3 : Inventory Management");
                Console.WriteLine(" Press 4 : Stock Account Management");
                Console.WriteLine(" Press 5 : Deck of Cards");
                Console.WriteLine(" Press 6 : Commercial Data Processing");

                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        AddressBookOperations addressBookOperations = new AddressBookOperations();
                        addressBookOperations.AddressOperation();
                        break;
                    case 2:
                        InventoryOperation inventoryOperation = new InventoryOperation();
                        inventoryOperation.InventoryManage();
                        break;
                    case 3:
                        InventoryDataManagementOperation.DataOperation();
                        break;
                    case 4:
                        StockManagement.StockPortfolio.StockReport();
                        break;
                    case 5:
                        DeckOfCards.PlayGame();
                        break;
                    case 6:
                        CommercialDataProcessing.StockAccountOperations.StockAccountChoice();
                        break;
                }

                Console.WriteLine("\nDo you Want Continue Again? Yes or No ");
                repeat = Console.ReadLine().ToLower();
            } while (repeat == "yes");
        }
    }
}
