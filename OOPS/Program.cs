// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OOPS
{
    using OOPS.Address_Book;
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
                /*
                Console.WriteLine("\n Perform Any Operation On Inventory Management");
                Console.WriteLine(" Press 1 : Add New Item");
                Console.WriteLine(" Press 2 : Update Items");
                Console.WriteLine(" Press 3 : Remove The Items");
                Console.WriteLine(" Press 4 : Get Inventory Details");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        InventoryManagement.AddItem();
                        break;
                    case 2:
                        InventoryManagement.Update();
                        break;
                    case 3:
                        InventoryManagement.DeleteItem();
                        break;
                    case 4:
                        InventoryManagement.GetInventoryDetails();
                        break;
                }
                */

                Console.WriteLine(" Press 1 : To Add a Person to Address Book");
                Console.WriteLine(" Press 2 : To Remove a Person From Address Book");
                Console.WriteLine(" Press 3 : To Search a Person Using First Name in Address Book");
                Console.WriteLine(" Press 4 : To Print The Total Persons Data from Address Book");

                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        AddressBook_Operations.AddPerson();
                        break;
                    case 2:
                        AddressBook_Operations.RemovePerson();
                        break;
                    case 3:
                        AddressBook_Operations.SearchPerson();
                        break;
                    case 4:
                        AddressBook_Operations.ListPeople();
                        break;
                }
            }
        }
    }
}
