// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeRepository.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagement.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using EmployeeManagement.Model;

    /// <summary>
    /// Repository class which contains method for CRUD operations
    /// </summary>
    /// <seealso cref="EmployeeManagement.Repository.IEmployeeRepository" />
    public class EmployeeRepository : IEmployeeRepository
    {
        /// <summary>
        /// The SQL connection
        /// </summary>
        private SqlConnection sqlConnection;

        /// <summary>
        /// To Handle Connection related activities
        /// </summary>
        private void Connection()
        {
            string connectionString = "Server=(Localdb)\\MSSQLLocaldb;Database=EmployeeManagement;Integrated Security=True;";
            this.sqlConnection = new SqlConnection(connectionString);
        }

        /// <summary>
        /// To Add Employee details to the database.
        /// </summary>
        /// <param name="employee">The object.</param>
        /// <returns>Added Employees</returns>
        public bool AddEmployee(Employee employee)
        {
            this.Connection();
            SqlCommand sqlCommand = new SqlCommand("AddNewEmpDetails", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Empid", employee.Empid);
            sqlCommand.Parameters.AddWithValue("@Name", employee.Name);
            sqlCommand.Parameters.AddWithValue("@City", employee.City);
            sqlCommand.Parameters.AddWithValue("@Address", employee.Address);

            this.sqlConnection.Open();
            int affectedRecords = sqlCommand.ExecuteNonQuery();
            this.sqlConnection.Close();
            if (affectedRecords >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets all employees from database.
        /// </summary>
        /// <returns>Employee List</returns>
        public List<Employee> GetAllEmployees()
        {
            this.Connection();
            List<Employee> EmpList = new List<Employee>();
            SqlCommand sqlCommand = new SqlCommand("GetEmployees", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            this.sqlConnection.Open();
            dataAdapter.Fill(dataTable);
            this.sqlConnection.Close();

            ////Bind EmpModel generic list using LINQ 
            EmpList = (from DataRow dr in dataTable.Rows
                       select new Employee()
                       {
                           Empid = Convert.ToInt32(dr["Empid"]),
                           Name = Convert.ToString(dr["Name"]),
                           City = Convert.ToString(dr["City"]),
                           Address = Convert.ToString(dr["Address"])
                       }).ToList();
            return EmpList;
        }

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>Updated Employees</returns>
        public bool UpdateEmployee(Employee employee)
        {
            this.Connection();
            SqlCommand sqlCommand = new SqlCommand("UpdateEmpDetails", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Empid", employee.Empid);
            sqlCommand.Parameters.AddWithValue("@Name", employee.Name);
            sqlCommand.Parameters.AddWithValue("@City", employee.City);
            sqlCommand.Parameters.AddWithValue("@Address", employee.Address);
            this.sqlConnection.Open();
            int affectedRecords = sqlCommand.ExecuteNonQuery();
            this.sqlConnection.Close();
            if (affectedRecords >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns>Delete Employee</returns>
        public bool DeleteEmployee(int Id)
        {
            this.Connection();
            SqlCommand sqlCommand = new SqlCommand("DeleteEmpById", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Empid", Id);

            this.sqlConnection.Open();
            int affectedRecords = sqlCommand.ExecuteNonQuery();
            this.sqlConnection.Close();
            if (affectedRecords >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
