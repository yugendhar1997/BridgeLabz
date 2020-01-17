// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryManagement.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.InventoryManagement
{
    public class InventoryDataManagementOperation
    {
        private static object invetoryManagement;

        public static void DataOperation()
        {
            char again;
            do
            {
                InventoryManagement invetoryManagement = new InventoryManagement();
                Console.WriteLine("*********************************** ");
                Console.WriteLine("\n 1 : Inventory Update File \n 2 : Delete File \n 3 : Inventory reports \n ");
                Console.WriteLine("Enter Your Choice To Run Operation ");
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

                Console.WriteLine("\nDo You want To Continue the Press 'Y' Or 'N' ");
                again = Console.ReadLine()[0];
            }
            while (again == 'Y' || again == 'y');
            Console.ReadLine();
        }
    }

}