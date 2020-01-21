// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockReport.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OOPS.StockManagement
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Stock Report Details
    /// </summary>
    public class StockReport
    {

        public string nameOfShare { get; set; }
        public int numberOfShare { get; set; }
        public double sharePrice { get; set; }

        public void StockGetInput()
        {
            try
            {
                Console.WriteLine("Enter Name of Stock ");
                this.nameOfShare = Console.ReadLine();
                Console.WriteLine("Enter Number of Share ");
                this.numberOfShare = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Price of Per Share ");
                this.sharePrice = Convert.ToInt32(Console.ReadLine());
            }

            catch (InvalidCastException castException)
            {
                Console.WriteLine("Please Enter Valide Input " + castException);
            }

            catch (Exception exception)
            {
                Console.WriteLine("Please Enter Valide Input" + exception);
            }

        }

        internal IEnumerable<object> Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }

}
