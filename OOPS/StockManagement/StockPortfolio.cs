﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockPortfolio.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OOPS.StockManagement
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;

    /// <summary>
    /// Details of StockPortfolio
    /// </summary>
    public class StockPortfolio
    {
        /// <summary>
        /// The path
        /// </summary>
        private static string path = @"C:\Users\Bridgelabz\source\repos\OOPS\StockManagement\Stock.json";

        /// <summary>
        /// Stocks the report.
        /// </summary>
        public static void StockReport()
        {
            StreamReader streamReader = new StreamReader(path);
            string readString = streamReader.ReadToEnd();
            List<StockReport> stockList = JsonConvert.DeserializeObject<List<StockReport>>(readString);
            double totalSharePrice = 0.0;

            foreach (StockReport objStock in stockList)
            {
                totalSharePrice = objStock.sharePrice * objStock.numberOfShare;
                Console.WriteLine("Name Of Stock : " + objStock.nameOfShare);
                Console.WriteLine("Total Share : " + objStock.numberOfShare);
                Console.WriteLine("Each Share Price " + objStock.sharePrice);
                Console.WriteLine("Total Share Price of Stock " + totalSharePrice);
            }

            Console.WriteLine("Where You Want to Invest Your Share");
            string userStockName = Console.ReadLine();
            foreach (StockReport objStock1 in stockList)
            {
                try
                {
                    if (userStockName.Equals(objStock1.nameOfShare))
                    {
                        Console.WriteLine("How Many Share You Want To Buy");
                        int userNumberOfShare = Convert.ToInt32(Console.ReadLine());
                        double totalUserSharePrice = userNumberOfShare * objStock1.sharePrice;

                        int availableShare = objStock1.numberOfShare - userNumberOfShare;
                        objStock1.numberOfShare = availableShare;

                        Console.WriteLine("Your Total Share Price : " + totalUserSharePrice);
                        Console.WriteLine("Available Share Of {0} is {1}", objStock1.nameOfShare, availableShare);
                        totalSharePrice = objStock1.sharePrice * objStock1.numberOfShare;
                        Console.WriteLine("Name Of Stock : " + objStock1.nameOfShare);
                        Console.WriteLine("Total Share : " + objStock1.numberOfShare);
                        Console.WriteLine("Each Share Price " + objStock1.sharePrice);
                    }

                    string jsonStock = JsonConvert.SerializeObject(objStock1);
                    Console.WriteLine(jsonStock);
                    StreamWriter streamWriter = new StreamWriter(path);
                    streamWriter.WriteLine(jsonStock);
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine("Invalide Formate Entered" + formatException);
                }
            }
        }

        /// <summary>
        /// Adds the stock.
        /// </summary>
        public static void AddStock()
        {
            Console.WriteLine("Enter Number of stock ");
            int numberOfStock = Convert.ToInt32(Console.ReadLine());
            StockReport[] stock = new StockReport[numberOfStock];

            for (int i = 0; i < numberOfStock; i++)
            {
                stock[i] = new StockReport();
                stock[i].StockGetInput();
            }

            List<StockReport> writeStock = new List<StockReport>();
            for (int i = 0; i < numberOfStock; i++)
            {
                writeStock.Add(stock[i]);
            }

            string jsonStock = JsonConvert.SerializeObject(stock, Formatting.Indented);
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.WriteLine(jsonStock);
            streamWriter.Close();
        }
    }
}