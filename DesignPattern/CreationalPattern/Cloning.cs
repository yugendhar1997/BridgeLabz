// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Cloning.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.CreationalPattern
{
    using System;

    /// <summary>
    /// This is the class for cloning.
    /// </summary>
    public class Cloning
    {
        /// <summary>
        /// Cloning the operation.
        /// </summary>
        public static void CloningOperation()
        {
            Developer developer = new Developer();
            Console.WriteLine("Enter Your Id ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Name ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Salary ");
            int salary = Convert.ToInt32(Console.ReadLine());

            developer.EmployeeId = id;
            developer.EmployeeName = name;
            developer.EmployeeSalary = salary;

            developer.GetDetails();
            Developer developerClone = (Developer)developer.Clone();

            Console.WriteLine("Enter Name to Change Clone");
            name = Console.ReadLine();
            developerClone.EmployeeName = name;
            Console.WriteLine("After Cloning");
            developerClone.GetDetails();
        }
    }
}