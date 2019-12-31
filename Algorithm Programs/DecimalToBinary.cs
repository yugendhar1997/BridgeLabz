// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DecimalToBinary.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Algorithm_Programs
{
    using System;

    /// <summary>
    /// This Program is Convert Decimal To Binary
    /// </summary>
    public class DecimalToBinary
    {
        /// <summary>
        /// Decimals the conversion.
        /// </summary>
        public static void DecimalConversion()
        {
            Console.WriteLine("Enter number for conversion");
            int num = Convert.ToInt32(Console.ReadLine());
            Utility.Conversion(num);
        }
    }
}
