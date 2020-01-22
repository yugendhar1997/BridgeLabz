// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBookImp.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.StructuralDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is the class for AddressBookImplementation which implement AddressBookDetail interface.
    /// </summary>
    /// <seealso cref="DesignPattern.StructuralDesignPattern.AddressBookDetails" />
    public class AddressBookImp : AddressBookDetails
    {
        /// <summary>
        /// Address instance.
        /// </summary>
        /// <returns></returns>
        public string address()
        {
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            return address;
        }

        /// <summary>
        /// City instance.
        /// </summary>
        /// <returns></returns>
        public string city()
        {
            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            return city;
        }

        /// <summary>
        /// method for Name instance.
        /// </summary>
        /// <returns></returns>
        public string name()
        {
            Console.WriteLine("Enter Last Name");
            string name = Console.ReadLine();
            return name;
        }

        /// <summary>
        /// Phone no instance.
        /// </summary>
        /// <returns></returns>
        public int phoneNo()
        {
            Console.WriteLine("Enter phone Number");
            int phoneNo = Convert.ToInt32(Console.ReadLine());
            return phoneNo;
        }

        /// <summary>
        /// State instance.
        /// </summary>
        /// <returns></returns>
        public string state()
        {
            Console.WriteLine("Enter state");
            string state = Console.ReadLine();
            return state;
        }

        /// <summary>
        /// Zipcode instance.
        /// </summary>
        /// <returns></returns>
        public int zipCode()
        {
            Console.WriteLine("Enter Zip Code");
            int zipCode = Convert.ToInt32(Console.ReadLine());
            return zipCode;
        }
    }
}