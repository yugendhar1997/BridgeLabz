﻿//-----------------------------------------------------------------------
// <copyright file="Cloning.cs" company="Bridgelabz" Author="Jayashree sawakare">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace DesignPatterns.CreationalPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is the class for clonning.
    /// </summary>
    public class Cloning
    {
        /// <summary>
        /// method to perform Cloning operation.
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
            developer.employeeId = id;
            developer.employeeName = name;
            developer.employeeSalary = salary;
            developer.getDetails();
            Developer developerClone = (Developer)developer.Clone();
            Console.WriteLine("Enter Name to Change Clone");
            name = Console.ReadLine();
            developerClone.employeeName = name;
            Console.WriteLine("After Cloning");
            developerClone.getDetails();
        }
    }
}



