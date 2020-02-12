// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IEmployeeManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar"/>
// --------------------------------------------------------------------------------------------------------------------

using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Manager
{
    /// <summary>
    /// Interface for manager class
    /// </summary>
    public interface IEmployeeManager
    {
        /// <summary>
        /// Adds the specified emp.
        /// </summary>
        /// <param name="emp">The emp.</param>
        /// <returns></returns>
        string Add(Employee emp);

        /// <summary>
        /// Retrieves all employees.
        /// </summary>
        /// <returns></returns>
        List<Employee> Retrieve();

        /// <summary>
        /// Deletes the employee of the specified id.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        string Delete(int id);

        /// <summary>
        /// Updates the specified employee.
        /// </summary>
        /// <param name="emp">The emp.</param>
        /// <returns></returns>
        string Update(Employee emp);
        
    }
}
