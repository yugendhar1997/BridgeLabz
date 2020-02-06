using EmployeeManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Manager
{
    public interface IEmployeeManager
    {
        /// <summary>
        /// Gets the emp datails.
        /// </summary>
        void GetEmpDatails();

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="obj">The object.</param>
        void AddEmployee(Employee obj);

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        void DeleteEmployee(int id);

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="obj">The object.</param>
        void UpdateEmployee(Employee obj);
    }
}
