// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OOPS
{
    public class Utility
    {
        /// <summary>
        /// it create list of Rice class to stored multiple object.
        /// </summary>
        public IList<Rice> rice { get; set; }

        /// <summary>
        /// it create list of Wheats class to stored multiple object.
        /// </summary>
        public IList<Wheats> wheats { get; set; }

        /// <summary>
        /// it create list of Pulses class to stored multiple object.
        /// </summary>
        public IList<Pulses> pulses { get; set; }

        /// <summary>
        /// this method take inventory details 
        /// </summary>
        public static void InventoryManagementReport()
        {
            double totalRicePrice = 0;
            double totalWheatsPrice = 0;
            double totalPulsesPrice = 0;
            string path = "D:\\bridgelabz\\ObjectOrientedPrograms\\ObjectOrientedPrograms\\Inventory.json";
            StreamReader streamReader = new StreamReader(path);
            string readString = streamReader.ReadToEnd();
            Utility utility = (Utility)JsonConvert.DeserializeObject(readString, typeof(Utility));
            foreach (Rice objeRice in utility.rice)
            {
                string name = objeRice.name;
                double price = objeRice.price;
                double weight = objeRice.weight;
                totalRicePrice = totalRicePrice + price * weight;
                Console.WriteLine("Name Of Rice " + name);
                Console.WriteLine("Price " + price);
                Console.WriteLine("Weight " + weight + "\n\n");
            }
            Console.WriteLine("Total Amount Of Rice  " + totalRicePrice);
            Console.WriteLine("*********************");
            foreach (Wheats objWheats in utility.wheats)
            {
                string name = objWheats.name;
                double price = objWheats.price;
                double weight = objWheats.weight;
                totalWheatsPrice = totalWheatsPrice + price * weight;
                Console.WriteLine("Name Of Wheats " + name);
                Console.WriteLine("Price " + price);
                Console.WriteLine("Weight " + weight + "\n\n");
            }
            Console.WriteLine("Total Amount Of Wheats  " + totalWheatsPrice);
            Console.WriteLine("*********************");
            foreach (Pulses objPulses in utility.pulses)
            {
                string name = objPulses.name;
                double price = objPulses.price;
                double weight = objPulses.weight;
                totalPulsesPrice = totalPulsesPrice + price * weight;
                Console.WriteLine("Name Of Pulses " + name);
                Console.WriteLine("Price " + price);
                Console.WriteLine("Weight " + weight + "\n");
            }
            Console.WriteLine("Total Amount Of Pulses   " + totalPulsesPrice);
        }
    }
}
