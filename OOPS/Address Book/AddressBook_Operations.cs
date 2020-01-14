// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook_Operations.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OOPS.Address_Book
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// This Class Contains All Address Book Functions Which are useful 
    /// </summary>
    public class AddressBook_Operations
    {
        /// <summary>
        /// This people List to Store Persons Objects
        /// </summary>
        public static List<Person> People = new List<Person>();

        /// <summary>
        /// Adds the person.
        /// </summary>
        public static void AddPerson()
        {
            Person person = new Person();
            Console.WriteLine("Enter First Name :");
            person.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name :");
            person.LastName = Console.ReadLine();

            Console.WriteLine("Enter Phone Number");
            person.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Address 1:");
            string[] addresses = new string[2];
            addresses[0] = Console.ReadLine();

            Console.WriteLine("Enter Address 2: (Optional)");
            Console.WriteLine("Enter City , State , ZipCode etc.. ");
            addresses[1] = Console.ReadLine();

            person.Address = addresses;

            People.Add(person);
            Console.WriteLine(person.FirstName + " Added Successfully");
        }

        /// <summary>
        /// Removes the person.
        /// </summary>
        public static void RemovePerson()
        {
            Console.WriteLine("Enter The First Name of the Person Would you like to remove..");
            string firstName = Console.ReadLine();
            Person person = People.FirstOrDefault(x => x.FirstName.ToLower() == firstName.ToLower());

            if (person == null)
            {
                Console.WriteLine("The Person Could not be found");
                return;
            }
            else
            {
                Console.WriteLine("Are you want to remove this person from your Address Book(Y/N)");
                PrintPerson(person);

                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    People.Remove(person);
                    Console.WriteLine();
                    Console.WriteLine(firstName + " Removed Successfully");
                }
            }
        }

        /// <summary>
        /// Lists the people.
        /// </summary>
        public static void ListPeople()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("Your address book is empty");
                return;
            }

            Console.WriteLine("Current people in address book:\n");
            foreach (var person in People)
            {
                PrintPerson(person);
            }
        }

        /// <summary>
        /// Searches the person.
        /// </summary>
        public static void SearchPerson()
        {
            List<Person> People = FindPeopleByFirstName();

            if (People.Count == 0)
            {
                Console.WriteLine("That person could not be found");
                return;
            }

            Console.WriteLine("Here are the current people in your address book matching that search:\n");
            foreach (var person in People)
            {
                PrintPerson(person);
            }
        }

        /// <summary>
        /// Finds the first name of the people by.
        /// </summary>
        /// <returns></returns>
        public static List<Person> FindPeopleByFirstName()
        {
            Console.WriteLine("Enter the first name of the person you would like to find.");
            string firstName = Console.ReadLine();
            return People.Where(x => x.FirstName.ToLower() == firstName.ToLower()).ToList();
        }

        /// <summary>
        /// Prints the person.
        /// </summary>
        /// <param name="person">The person.</param>
        public static void PrintPerson(Person person)
        {
            Console.WriteLine("First Name : " + person.FirstName);
            Console.WriteLine("Last Name : " + person.LastName);
            Console.WriteLine("Phone Number : " + person.PhoneNumber);
            Console.WriteLine("Address 1 : " + person.Address[0]);
            Console.WriteLine("Address 2 : " + person.Address[1]);
            Console.WriteLine("-------------------------------------------");
        }
    }
}
