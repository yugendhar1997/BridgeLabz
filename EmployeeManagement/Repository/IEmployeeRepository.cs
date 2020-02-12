// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEmployeeRepository.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagement.Repository
{
    using System.Collections.Generic;
    using EmployeeManagement.Model;

    /// <summary>
    /// Interface which contains the declaration of crud operations
    /// </summary>
    public interface IEmployeeRepository
    {
        /// <summary>
        /// Adds the employee to database.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns>Employee Object</returns>
        bool AddEmployee(Employee obj);

        /// <summary>
        /// Gets all employees from database.
        /// </summary>
        /// <returns>All Employee Details</returns>
        List<Employee> GetAllEmployees();

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns>Employee Object</returns>
        bool UpdateEmployee(Employee obj);

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns>Deleted Employee</returns>
        bool DeleteEmployee(int Id);
    }
}
