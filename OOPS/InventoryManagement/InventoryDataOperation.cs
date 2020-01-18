// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryDataManagementOperation.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OOPS.InventoryManagement
{
    using System;

    /// <summary>
    /// Operations Of Inventory Management
    /// </summary>
    public class InventoryDataManagementOperation
    {
        /// <summary>
        /// Data operations.
        /// </summary>
        public static void DataOperation()
        {
            string repeat;

            do
            {
                InventoryManagement invetoryManagement = new InventoryManagement();
                Console.WriteLine("Perform An Opearation on Inventory Data Management");
                Console.WriteLine("Press 1 : Inventory Update File");
                Console.WriteLine("Press 2 : Delete File");
                Console.WriteLine("Press 3 : Inventory Reports");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        invetoryManagement.UpdateFile();
                        break;
                    case 2:
                        invetoryManagement.DeleteFileItem();
                        break;
                    case 3:
                        Utility.InventoryManagementReport();
                        break;
                }

                Console.WriteLine("\nDo You want To Continue the Press 'Yes' Or 'No' ");
                repeat = Console.ReadLine().ToLower();
            }
            while (repeat == "yes");
        }
    }
}