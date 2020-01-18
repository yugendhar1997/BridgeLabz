// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryManagement.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OOPS.InventoryManagement
{
    using System;
    using System.IO;
    using System.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Contains Inventory Management Operations
    /// </summary>
    public class InventoryManagement
    {
        /// <summary>
        /// The JSon file
        /// </summary>
        private string jsonFile = @"C:\Users\Bridgelabz\source\repos\OOPS\InventoryManagement\Inventory.json";

        /// <summary>
        /// Gets the details.
        /// </summary>
        public void GetDetails()
        {
            var json = File.ReadAllText(this.jsonFile);
            try
            {
                var jsonObject = JObject.Parse(json);
                if (jsonObject != null)
                {
                    JArray riceArrary = (JArray)jsonObject["Rice"];
                    if (riceArrary != null)
                    {
                        foreach (var item in riceArrary)
                        {
                            Console.WriteLine("Rice Name :" + item["name"].ToString());
                            Console.WriteLine("Rice Price :" + item["price"]);
                            Console.WriteLine("Rice Weight :" + item["weight"]);
                        }
                    }

                    JArray wheatsArrary = (JArray)jsonObject["Wheats"];
                    if (riceArrary != null)
                    {
                        foreach (var item in wheatsArrary)
                        {
                            Console.WriteLine("\nWheats Name :" + item["name"].ToString());
                            Console.WriteLine("Wheats Price :" + item["price"]);
                            Console.WriteLine("Wheats Weight :" + item["weight"]);
                        }
                    }

                    JArray pulsesArrary = (JArray)jsonObject["Pulses"];
                    if (riceArrary != null)
                    {
                        foreach (var item in pulsesArrary)
                        {
                            Console.WriteLine("\nPulses Name :" + item["name"].ToString());
                            Console.WriteLine("Pulses Price :" + item["price"]);
                            Console.WriteLine("Pulses Weight :" + item["weight"]);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception Occurs : " + exception);
            }
        }

        /// <summary>
        /// This Method Add The Item into the List.
        /// </summary>
        public void AddItem()
        {
            Console.WriteLine("Enter Item Name : ");
            var itemName = Console.ReadLine();
            Console.WriteLine("Enter Type Of Item Name : ");
            string itemTypeName = Console.ReadLine();
            Console.WriteLine("Enter Item Price : ");
            var itemPrice = Console.ReadLine();
            Console.WriteLine("Enter Item Weight : ");
            var itemWeight = Console.ReadLine();
            var newItem = "{ 'name': '" + itemTypeName + "','price':" + itemPrice + ",'weight':" + itemWeight + "}";

            var json = File.ReadAllText(this.jsonFile);
            var jsonObj = JObject.Parse(json);

            var itemArrary = jsonObj.GetValue(itemName) as JArray;
            var newItemObj = JObject.Parse(newItem);
            Console.WriteLine("newitem " + newItemObj);
            itemArrary.Add(newItemObj);
            Console.WriteLine("Name " + itemArrary);
            jsonObj[itemName] = itemArrary;

            string newJsonResult = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
            File.WriteAllText(this.jsonFile, newJsonResult);
        }

        /// <summary>
        /// this method update the file details
        /// </summary>
        public void UpdateFile()
        {
            string json = File.ReadAllText(this.jsonFile);
            try
            {
                var jsonObject = JObject.Parse(json);
                Console.WriteLine("Enter Item Name ");
                string itemNameToUpdate = Console.ReadLine();
                JArray riceArrary = (JArray)jsonObject[itemNameToUpdate];
                Console.Write("Enter Item Name to Update : ");
                var itemName = Console.ReadLine();
                Console.Write("Enter new Item name : ");
                var newItemName = Convert.ToString(Console.ReadLine());

                foreach (var item in riceArrary.Where(obj => obj["name"].Value<string>().Equals(itemName)))
                {
                    item["name"] = !string.IsNullOrEmpty(newItemName) ? newItemName : string.Empty;
                }

                jsonObject["name"] = riceArrary;
                string output = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                File.WriteAllText(this.jsonFile, output);
                Console.WriteLine(newItemName + " is Updated on " + itemName);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Update Error : " + exception.Message.ToString());
            }
        }

        /// <summary>
        /// this method use to delete particular record
        /// </summary>
        public void DeleteFileItem()
        {
            var jsonFileRead = File.ReadAllText(this.jsonFile);
            try
            {
                var jsonObjectConvert = JObject.Parse(jsonFileRead);
                Console.WriteLine("Enter Item Name ");
                string itemNameToDelete = Console.ReadLine();

                JArray itemsArrary = (JArray)jsonObjectConvert[itemNameToDelete];
                Console.Write("Enter Name to Delete Item : ");
                string itemName = Console.ReadLine();

                var itemToDeleted = itemsArrary.FirstOrDefault(obj => obj["name"].Value<string>().Equals(itemName));
                itemsArrary.Remove(itemToDeleted);

                string output = JsonConvert.SerializeObject(jsonObjectConvert, Formatting.Indented);
                File.WriteAllText(this.jsonFile, output);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception Occurs : " + exception);
            }
        }
    }
}