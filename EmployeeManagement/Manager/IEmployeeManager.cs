// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEmployeeManager.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagement.Manager
{
    using System.Collections.Generic;
    using EmployeeManagement.Model;

    /// <summary>
    /// Interface for manager class
    /// </summary>
    public interface IEmployeeManager
    {
        /// <summary>
        /// Adds the specified emp.
        /// </summary>
        /// <param name="emp">The emp.</param>
        /// <returns>Employee Object</returns>
        string Add(Employee emp);

        /// <summary>
        /// Retrieves all employees.
        /// </summary>
        /// <returns>Employee Details</returns>
        List<Employee> Retrieve();

        /// <summary>
        /// Deletes the employee of the specified id.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Deleted Employee</returns>
        string Delete(int id);

        /// <summary>
        /// Updates the specified employee.
        /// </summary>
        /// <param name="emp">The emp.</param>
        /// <returns>Updated Employee</returns>
        string Update(Employee emp);
    }
}
