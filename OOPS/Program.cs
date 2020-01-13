using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OOPS
{
    class Program
    {
        public static void Main(string[] args)
        {
            InventoryManagement inventoryManagement = new InventoryManagement();
            Console.WriteLine("Choose Options");
            Console.WriteLine("Press 1 : Add New Item");
            Console.WriteLine("Press 2 : Update Items");
            Console.WriteLine("Press 3 : Remove The Items");
            Console.WriteLine("Press 4 : Get Inventory Details");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    inventoryManagement.AddItem();
                    break;
                case 2:
                    inventoryManagement.Update();
                    break;
                case 3:
                    inventoryManagement.DeleteItem();
                    break;
                case 4:
                    inventoryManagement.GetInventoryDetails();
                    break;
            }
        }
    }
}
