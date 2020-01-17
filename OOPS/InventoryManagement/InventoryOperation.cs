// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryOperation.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.InventoryManagement
{
    public class InventoryOperation
    {
        public void InventoryManage()
        {
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("1 : Get Details \n 2 : Add Details\n");

                    InventoryManagement inventoryManagement = new InventoryManagement();
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}