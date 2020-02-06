using EmployeeManagementSystem.Model;
using EmployeeManagementSystem.Repocitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Manager
{
    public class EmployeeManager : IEmployeeManager
    {
        public void GetEmpDatails()
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            employeeRepository.GetAllEmployees();
        }

        public void UpdateEmployee(Employee obj)
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            employeeRepository.UpdateEmployee(obj);
        }

        public void DeleteEmployee(int Id)
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            employeeRepository.DeleteEmployee(Id);
        }

        public void AddEmployee(Employee obj)
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            employeeRepository.AddEmployee(obj);
        }
    }
}
