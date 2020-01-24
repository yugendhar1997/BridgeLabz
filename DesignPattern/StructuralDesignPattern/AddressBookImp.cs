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
    public class AddressBookImp : IAddressBookDetails
    {
        /// <summary>
        /// Address instance.
        /// </summary>
        /// <returns>The Address</returns>
        public string Address()
        {
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            return address;
        }

        /// <summary>
        /// City instance.
        /// </summary>
        /// <returns>The City</returns>
        public string City()
        {
            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            return city;
        }

        /// <summary>
        /// method for Name instance.
        /// </summary>
        /// <returns>The Name</returns>
        public string Name()
        {
            Console.WriteLine("Enter Last Name");
            string name = Console.ReadLine();
            return name;
        }

        /// <summary>
        /// Phone no instance.
        /// </summary>
        /// <returns>Phone Number</returns>
        public int PhoneNo()
        {
            Console.WriteLine("Enter phone Number");
            int phoneNo = Convert.ToInt32(Console.ReadLine());
            return phoneNo;
        }

        /// <summary>
        /// State instance.
        /// </summary>
        /// <returns>The State</returns>
        public string State()
        {
            Console.WriteLine("Enter state");
            string state = Console.ReadLine();
            return state;
        }

        /// <summary>
        /// ZipCode instance.
        /// </summary>
        /// <returns>The ZipCode</returns>
        public int ZipCode()
        {
            Console.WriteLine("Enter Zip Code");
            int zipCode = Convert.ToInt32(Console.ReadLine());
            return zipCode;
        }
    }
}