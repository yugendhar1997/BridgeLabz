// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar"/>
// --------------------------------------------------------------------------------------------------------------------

using EmployeeManagement.Model;
using EmployeeManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Manager
{
    /// <summary>
    /// Manager class for performing CRUD operations
    /// </summary>
    /// <seealso cref="EmployeeManagement.Manager.IEmployeeManager" />
    public class EmployeeManager : IEmployeeManager
    {
        private IEmployeeRepository empRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeManager"/> class.
        /// </summary>
        /// <param name="empRepository">The emp repository.</param>
        public EmployeeManager(IEmployeeRepository empRepository)
        {
            this.empRepository = empRepository;
        }

        /// <summary>
        /// Adds the specified emp.
        /// </summary>
        /// <param name="emp">The emp.</param>
        /// <returns></returns>
        public string Add(Employee emp)
        {
            if (empRepository.AddEmployee (emp))
            {
                return "Employee added Successfully";
            }
            return "Employee not added";
        }

        /// <summary>
        /// Deletes employee of the specified id.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public string Delete(int id)
        {
            if (empRepository.DeleteEmployee(id))
            {
                return "Employee Deleted Successfully";
            }
            return " Employee Not Deleted";
        }


        /// <summary>
        /// Retrieves all employees.
        /// </summary>
        /// <returns></returns>
        public List<Employee> Retrieve()
        {
            return empRepository.GetAllEmployees();
        }

        /// <summary>
        /// Updates the specified emp.
        /// </summary>
        /// <param name="emp">The emp.</param>
        /// <returns></returns>
        public string Update(Employee emp)
        {
            if (empRepository.UpdateEmployee(emp))
            {
                return " Employee Updated Successfully";
            }
            return "Employee Not Updated";
        }
    }
}
