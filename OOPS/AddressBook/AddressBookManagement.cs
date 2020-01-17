// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBookManagement.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OOPS.AddressBook
{
    using System;
    using System.IO;
    using System.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Manages The AddressBook
    /// </summary>
    public class AddressBookManagement
    {
        /// <summary>
        /// The JSon file Path
        /// </summary>
        private string jsonFile = @"C:\Users\Bridgelabz\source\repos\OOPS\AddressBook\AddressBook.json";

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
                    JArray addressArrary = (JArray)jsonObject["AddressBook"];
                    if (addressArrary != null)
                    {
                        foreach (var item in addressArrary)
                        {
                            Console.WriteLine("FirstName :" + item["firstName"].ToString() + "\n" + "LastName :" + item["lastName"] + "\n" + "Address :" + item["address"] + "\n" + "State :" + item["state"] + "\n" + "City :" + item["city"] + "\n" + "PhoneNo :" + item["phoneNo"] + "\n" + "ZipCode :" + item["zipCode"]);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occurs : " + e);
            }
        }

        /// <summary>
        /// Adds the item.
        /// </summary>
        public void AddItem()
        {
            Console.WriteLine("Enter First Name : ");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter last Name : ");
            var lastName = Console.ReadLine();
            Console.WriteLine("Enter address : ");
            var address = Console.ReadLine();
            Console.WriteLine("Enter state : ");
            var state = Console.ReadLine();
            Console.WriteLine("Enter city : ");
            var city = Console.ReadLine();
            Console.WriteLine("Enter Phone Number : ");
            var phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter ZipCode : ");
            var zipCode = Console.ReadLine();
            var newItem = "{ 'firstName': '" + firstName + "','lastName':'" + lastName + "','address':'" + address + "','state':'" + state + "','city':'" + city + "','phoneNo':" + phoneNumber + ",'zipCode':" + zipCode + "}";
            var json = File.ReadAllText(this.jsonFile);
            var jsonObj = JObject.Parse(json);
            var itemArrary = jsonObj.GetValue("AddressBook") as JArray;
            var newItemObj = JObject.Parse(newItem);
            Console.WriteLine("newitem " + newItemObj);
            itemArrary.Add(newItemObj);
            jsonObj["AddressBook"] = itemArrary;
            string newJsonResult = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
            File.WriteAllText(this.jsonFile, newJsonResult);
            Console.WriteLine("New Item Added Successfully");
        }

        /// <summary>
        /// Updates the file.
        /// </summary>
        public void UpdateFile()
        {
            string json = File.ReadAllText(this.jsonFile);
            try
            {
                var jsonObject = JObject.Parse(json);
                Console.WriteLine("Enter Item Name ");
                string itemNameToUpdate = Console.ReadLine();
                JArray addressArrary = (JArray)jsonObject[itemNameToUpdate];
                Console.Write("Enter Item Name to Update : ");
                var itemName = Console.ReadLine();
                Console.Write("Enter new First name : ");
                var newFirstName = Convert.ToString(Console.ReadLine());
                Console.Write("Enter new lastname  : ");
                var newLastName = Convert.ToString(Console.ReadLine());
                Console.Write("Enter new Address name : ");
                var newAddress = Convert.ToString(Console.ReadLine());
                Console.Write("Enter new State name : ");
                var newState = Convert.ToString(Console.ReadLine());
                Console.Write("Enter new City name : ");
                var newCity = Convert.ToString(Console.ReadLine());
                Console.Write("Enter new PhoneNo name : ");
                var newPhoneNo = Convert.ToString(Console.ReadLine());
                Console.Write("Enter new ZipCode name : ");
                var newZipCode = Convert.ToString(Console.ReadLine());
                var newItem = "{ 'firstName': '" + newFirstName + "','lastName':'" + newLastName + "','address':'" + newAddress + "','state':'" + newState + "','city':'" + newCity + "','phoneNo':'" + newPhoneNo + "','zipCode':'" + newZipCode + "'}";
                var itemArrary = jsonObject.GetValue("newItem") as JArray;

                foreach (var item in addressArrary.Where(obj => obj["firstName"].Value<string>().Equals(itemName)).ToList())
                {
                    item["firstName"] = !string.IsNullOrEmpty(newFirstName) ? newFirstName : string.Empty;
                    item["lastName"] = !string.IsNullOrEmpty(newLastName) ? newLastName : string.Empty;
                    item["address"] = !string.IsNullOrEmpty(newAddress) ? newAddress : string.Empty;
                    item["state"] = !string.IsNullOrEmpty(newState) ? newState : string.Empty;
                    item["city"] = !string.IsNullOrEmpty(newCity) ? newCity : string.Empty;
                    item["phoneNo"] = !string.IsNullOrEmpty(newPhoneNo) ? newPhoneNo : string.Empty;
                    item["zipCode"] = !string.IsNullOrEmpty(newZipCode) ? newZipCode : string.Empty;
                }

                jsonObject["AddressBook"] = addressArrary;
                string output = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                File.WriteAllText(this.jsonFile, output);
                Console.WriteLine("An Item Updated Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update Error : " + ex.Message.ToString());
            }
        }

        /// <summary>
        /// Deletes the file item.
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
                var itemName = Console.ReadLine();
                var itemToDeleted = itemsArrary.FirstOrDefault(obj => obj["firstName"].Value<string>() == itemName);
                itemsArrary.Remove(itemToDeleted);

                string output = JsonConvert.SerializeObject(jsonObjectConvert, Formatting.Indented);
                File.WriteAllText(this.jsonFile, output);
                Console.WriteLine("An Item Deleted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occurs : " + e);
            }
        }
    }
}
