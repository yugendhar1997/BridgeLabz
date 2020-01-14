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
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Inventory Management Operations
    /// </summary>
    public class InventoryManagement
    {
        /// <summary>
        /// JSon File Path
        /// </summary>
        public static string JsonFile = @"C:\Users\Bridgelabz\source\repos\OOPS\Inventory Management\Inventory.json";

        /// <summary>
        /// This Function is for Add Items
        /// </summary>
        public static void AddItem()
        {
            Console.WriteLine("Enter Item Type");
            string itemType = Console.ReadLine();
            Console.WriteLine("Enter Item Price");
            double itemPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Item Weight");
            double itemWeight = Convert.ToDouble(Console.ReadLine());

            var newItem = "{ 'Name': '" + itemType + "','Price':" + itemPrice + ",'Weight':" + itemWeight + "}";
            var json = File.ReadAllText(JsonFile);
            var jsonObject = JObject.Parse(json);

            var newItemArray = jsonObject.GetValue("Pulses") as JArray;
            var newItemAdd = JObject.Parse(newItem);
            newItemArray.Add(newItemAdd);

            jsonObject["Pulses"] = newItemArray;
            string newJsonResult = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);

            File.WriteAllText(JsonFile, newJsonResult);
            Console.WriteLine(newItem + " A New Item is Added Successfully...");
        }

        /// <summary>
        /// This Function is For Delete the Items
        /// </summary>
        public static void DeleteItem()
        {
            var json = File.ReadAllText(JsonFile);
            var jobject = JObject.Parse(json);
            JArray pulseArray = (JArray)jobject["Pulses"];

            Console.WriteLine("Enter Name To Delete Item");
            var itemName = Console.ReadLine();

            var itemToDeleted = pulseArray.FirstOrDefault(obj => obj["Name"].Value<string>() == itemName);
            pulseArray.Remove(itemToDeleted);

            string output = JsonConvert.SerializeObject(jobject, Formatting.Indented);
            File.WriteAllText(JsonFile, output);

            Console.WriteLine(itemName + " is Deleted Successfully..");
        }

        /// <summary>
        /// This Function is for Update Items Data
        /// </summary>
        public static void Update()
        {
            var json = File.ReadAllText(JsonFile);

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
            string output = JsonConvert.SerializeObject(jobject, Formatting.Indented);
            File.WriteAllText(JsonFile, output);

            Console.WriteLine(newItemName + " :is Updated on Old Item :" + itemName);
        }

        /// <summary>
        /// This Function is to Display The Inventory Details
        /// </summary>
        public static void GetInventoryDetails()
        {
            string json = File.ReadAllText(JsonFile);
            var jobject = JObject.Parse(json);
            Console.WriteLine("Rice Details Are  :" + jobject["Rice"].ToString());
            Console.WriteLine("Pulse Details Are  :" + jobject["Pulses"].ToString());
            Console.WriteLine("Wheat Details Are :" + jobject["Wheats"].ToString());
        }
    }
}
