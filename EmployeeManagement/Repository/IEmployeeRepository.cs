// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IEmployeeRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar"/>
// --------------------------------------------------------------------------------------------------------------------

using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Repository
{
    /// <summary>
    /// Interface which contains the declaration of crud operations
    /// </summary>
    public interface IEmployeeRepository
    {
        /// <summary>
        /// Adds the employee to database.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        bool AddEmployee(Employee obj);

        /// <summary>
        /// Gets all employees from database.
        /// </summary>
        /// <returns></returns>
        List<Employee> GetAllEmployees();

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        bool UpdateEmployee(Employee obj);

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        bool DeleteEmployee(int Id);
    }
}
