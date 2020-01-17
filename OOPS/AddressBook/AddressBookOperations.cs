// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBookOperations.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OOPS.AddressBook
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;

    /// <summary>
    /// Operations to the Address Book
    /// </summary>
    public class AddressBookOperations
    {
        /// <summary>
        /// Addresses the operation.
        /// </summary>
        public void AddressOperation()
        {
            try
            {
                string addressPath = @"C:\Users\Bridgelabz\source\repos\OOPS\AddressBook\AddressBook.json";
                string addressString = File.ReadAllText(addressPath);
                var addressData = JsonConvert.DeserializeObject<ListOfAddressBook>(addressString);
                List<AddressBookDetails> addressBookList;

                if (addressData == null)
                    addressBookList = new List<AddressBookDetails>();
                else
                    addressBookList = addressData.AddressBook;

                bool flag = true;
                while (flag)
                {
                    AddressBookManagement addressBookManagement = new AddressBookManagement();
                    Console.WriteLine(" Enter Any Choice To Perform Operations On AddressBook");
                    Console.WriteLine(" Press 1: Add Details to AddressBook");
                    Console.WriteLine(" Press 2: Update Daetails of AddressBook");
                    Console.WriteLine(" Press 3: Delete Details of AddressBook");
                    Console.WriteLine(" Press 4: Get The Details Of Address Book");

                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            addressBookManagement.AddItem();
                            break;
                        case 2:
                            addressBookManagement.UpdateFile();
                            break;
                        case 3:
                            addressBookManagement.DeleteFileItem();
                            break;
                        case 4:
                            addressBookManagement.GetDetails();
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
