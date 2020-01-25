// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Prototype.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.CreationalPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this is employee interface
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// this is abstract method of Employee
        /// </summary>
        /// <returns> it return object</returns>
        IEmployee Clone();

        /// <summary>
        /// this is abstract method get details of employee
        /// </summary>
        void GetDetails();
    }

    /// <summary>
    /// this is prototype class
    /// </summary>
    public class Prototype { }

    /// <summary>
    /// This Class Implemented by Employee
    /// </summary>
    /// <seealso cref="DesignPatterns.CreationalPattern.IEmployee" />
    public class Developer : IEmployee
    {
        /// <summary>
        /// Gets or sets the employee identifier.
        /// </summary>
        /// <value>
        /// The employee identifier.
        /// </value>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the name of the employee.
        /// </summary>
        /// <value>
        /// The name of the employee.
        /// </value>
        public string EmployeeName { get; set; }

        /// <summary>
        /// Gets or sets the employee salary.
        /// </summary>
        /// <value>
        /// The employee salary.
        /// </value>
        public int EmployeeSalary { get; set; }

        /// <summary>
        /// this method used to create clone of employee
        /// </summary>
        /// <returns>it return employee object</returns>
        public IEmployee Clone()
        {
            return (IEmployee)MemberwiseClone();
        }

        /// <summary>
        /// this method print employee details
        /// </summary>
        public void GetDetails()
        {
            Console.WriteLine("Developer :\nId : " + this.EmployeeId + "\nName : " + this.EmployeeName + "Salary : " + this.EmployeeSalary);
        }
    }

    /// <summary>
    /// this Tester class implemented from employee interface
    /// </summary>
    public class Tester : IEmployee
    {
        /// <summary>
        /// Gets or sets the employee identifier.
        /// </summary>
        /// <value>
        /// The employee identifier.
        /// </value>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the name of the employee.
        /// </summary>
        /// <value>
        /// The name of the employee.
        /// </value>
        public string EmployeeName { get; set; }

        /// <summary>
        /// Gets or sets the employee salary.
        /// </summary>
        /// <value>
        /// The employee salary.
        /// </value>
        public int EmployeeSalary { get; set; }

        /// <summary>
        /// this is abstract method of Employee
        /// </summary>
        /// <returns>
        /// it return object
        /// </returns>
        public IEmployee Clone()
        {
            //// return clone of employee object
            return (IEmployee)MemberwiseClone();
            ////  return (IEmployee)this.Clone();
        }

        /// <summary>
        /// this is abstract method get details of employee
        /// </summary>
        public void GetDetails()
        {
            Console.WriteLine("Tester : \nId : " + this.EmployeeId + "\nName : " + this.EmployeeName + "\nSalary : " + this.EmployeeSalary);
        }
    }
}
