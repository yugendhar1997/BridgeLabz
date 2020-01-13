// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryManagement.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OOPS
{
    using System;
    using System.IO;
    using System.Linq;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Inventory Management Operations
    /// </summary>
    public class InventoryManagement
    {
        /// <summary>
        /// JSon File Path
        /// </summary>
        public string JsonFile = @"C:\Users\Bridgelabz\source\repos\OOPS\Inventory.json";

        /// <summary>
        /// This Function is for Add Items
        /// </summary>
        public void AddItem()
        {
            Console.WriteLine("Enter Item Type");
            string itemType = Console.ReadLine();
            Console.WriteLine("Enter Item Price");
            double itemPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Item Weight");
            double itemWeight = Convert.ToDouble(Console.ReadLine());

            var newItem = "{ 'Name': '" + itemType + "','Price':'" + itemPrice + "','Weight':'" + itemWeight + "'}";
            var json = File.ReadAllText(this.JsonFile);
            var jsonObject = JObject.Parse(json);

            var newItemArray = jsonObject.GetValue("Pulses") as JArray;
            var newItemAdd = JObject.Parse(newItem);
            newItemArray.Add(newItemAdd);

            jsonObject["Pulses"] = newItemArray;
            string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObject, Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText(this.JsonFile, newJsonResult);

            Console.WriteLine(newItem + " A New Item is Added Successfully...");
        }

        /// <summary>
        /// This Function is For Delete the Items
        /// </summary>
        public void DeleteItem()
        {
            var json = File.ReadAllText(this.JsonFile);
            var jobj = JObject.Parse(json);
            JArray pulseArray = (JArray)jobj["Pulses"];

            Console.WriteLine("Enter Name To Delete Item");
            var itemName = Console.ReadLine();

            var itemToDeleted = pulseArray.FirstOrDefault(obj => obj["Name"].Value<string>() == itemName);
            pulseArray.Remove(itemToDeleted);

            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jobj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(this.JsonFile, output);

            Console.WriteLine(itemName + " is Deleted Successfully..");
        }

        /// <summary>
        /// This Function is for Update Items Data
        /// </summary>
        public void Update()
        {
            var json = File.ReadAllText(this.JsonFile);

            var jobject = JObject.Parse(json);
            JArray pulsesArray = (JArray)jobject["Pulses"];
            Console.WriteLine("Enter Name To Update");
            string itemName = Console.ReadLine();

            Console.WriteLine("Enter New Item Name");
            string newItemName = Console.ReadLine();

            foreach (var item in pulsesArray.Where(obj => obj["Name"].Value<string>() == itemName))
            {
                item["Name"] = !string.IsNullOrEmpty(newItemName) ? newItemName : string.Empty;
            }

            jobject["Pulses"] = pulsesArray;
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jobject, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(this.JsonFile, output);

            Console.WriteLine(newItemName + " :is Updated on Old Item :" + itemName);
        }

        /// <summary>
        /// This Function is to Display The Inventory Details
        /// </summary>
        public void GetInventoryDetails()
        {
            string json = File.ReadAllText(this.JsonFile);
            var jobj = JObject.Parse(json);
            Console.WriteLine("Rice Details Are  :" + jobj["Rice"].ToString());
            Console.WriteLine("Wheat Details Are :" + jobj["Wheats"].ToString());
            Console.WriteLine("Pulse Details Are  :" + jobj["Pulses"].ToString());
        }
    }
}
