// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryOperation.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OOPS.InventoryManagement
{
    using System;

    /// <summary>
    /// Operations of Inventory
    /// </summary>
    public class InventoryOperation
    {
        /// <summary>
        /// Inventories the manage.
        /// </summary>
        public void InventoryManage()
        {
            try
            {
                bool flag = true;
                while (flag)
                {
                    InventoryManagement inventoryManagement = new InventoryManagement();
                    Console.WriteLine(" Press 1 : To Get Details");
                    Console.WriteLine(" Press 2 : To Add Details");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            inventoryManagement.GetDetails();
                            break;
                        case 2:
                            inventoryManagement.AddItem();
                            break;
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}