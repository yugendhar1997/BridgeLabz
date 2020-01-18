// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OOPS
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;

    /// <summary>
    /// Utility Class To InventoryManagement
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// it create list of Rice class to stored multiple object.
        /// </summary>
        public IList<Rice> Rice { get; set; }

        /// <summary>
        /// it create list of Wheats class to stored multiple object.
        /// </summary>
        public IList<Wheats> Wheats { get; set; }

        /// <summary>
        /// it create list of Pulses class to stored multiple object.
        /// </summary>
        public IList<Pulses> Pulses { get; set; }

        /// <summary>
        /// this method take inventory details 
        /// </summary>
        public static void InventoryManagementReport()
        {
            double totalRicePrice = 0;
            double totalWheatsPrice = 0;
            double totalPulsesPrice = 0;

            string path = @"C:\Users\Bridgelabz\source\repos\OOPS\InventoryManagement\Inventory.json";
            StreamReader streamReader = new StreamReader(path);
            string readString = streamReader.ReadToEnd();
            Utility utility = (Utility)JsonConvert.DeserializeObject(readString, typeof(Utility));

            foreach (Rice objeRice in utility.Rice)
            {
                string name = objeRice.Name;
                double price = objeRice.Price;
                double weight = objeRice.Weight;
                totalRicePrice = totalRicePrice + price * weight;
                Console.WriteLine("Name Of Rice :" + name);
                Console.WriteLine("Price :" + price);
                Console.WriteLine("Weight :" + weight);
            }
            Console.WriteLine("Total Amount Of Rice :" + totalRicePrice);

            foreach (Wheats objWheats in utility.Wheats)
            {
                string name = objWheats.Name;
                double price = objWheats.Price;
                double weight = objWheats.Weight;
                totalWheatsPrice = totalWheatsPrice + price * weight;
                Console.WriteLine("\nName Of Wheats :" + name);
                Console.WriteLine("Price :" + price);
                Console.WriteLine("Weight :" + weight);
            }
            Console.WriteLine("Total Amount Of Wheats :" + totalWheatsPrice);

            foreach (Pulses objPulses in utility.Pulses)
            {
                string name = objPulses.Name;
                double price = objPulses.Price;
                double weight = objPulses.Weight;
                totalPulsesPrice = totalPulsesPrice + price * weight;
                Console.WriteLine("\nName Of Pulses :" + name);
                Console.WriteLine("Price :" + price);
                Console.WriteLine("Weight :" + weight);
            }
            Console.WriteLine("Total Amount Of Pulses :" + totalPulsesPrice);
        }
    }
}
