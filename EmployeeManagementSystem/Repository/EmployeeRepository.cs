using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using EmployeeManagementSystem.Model;

namespace EmployeeManagementSystem.Repocitory
{
    public class EmployeeRepository
    {
        private SqlConnection sqlConnection;

        private void Connection()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EmployeeManagement;Integrated Security=SSPI";
            sqlConnection = new SqlConnection(connectionString);
        }

        public bool AddEmployee(Employee employeeObject)
        {
            Connection();
            SqlCommand sqlCommand = new SqlCommand("AddEmployee", sqlConnection)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCommand.Parameters.AddWithValue("@Id", employeeObject.Id);
            sqlCommand.Parameters.AddWithValue("@FullName", employeeObject.FullName);
            sqlCommand.Parameters.AddWithValue("@Email", employeeObject.Email);
            sqlCommand.Parameters.AddWithValue("@Address", employeeObject.Address);
            sqlCommand.Parameters.AddWithValue("@Password", employeeObject.Password);

            sqlConnection.Open();
            int affectedRecords = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            if (affectedRecords >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Employee> GetAllEmployees()
        {
            Connection();
            List<Employee> employeeList = new List<Employee>();
            SqlCommand sqlCommand = new SqlCommand("GetEmployees", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();

            sqlConnection.Open();
            dataAdapter.Fill(dataTable);
            sqlConnection.Close();

            employeeList = (from DataRow datarow in dataTable.Rows
                            select new Employee()
                            {
                                Id = Convert.ToInt32(datarow["Id"]),
                                FullName = Convert.ToString(datarow["FullName"]),
                                Email = Convert.ToString(datarow["Email"]),
                                Address = Convert.ToString(datarow["Address"]),
                                Password = Convert.ToInt32(datarow["Password"])
                            }).ToList();

            return employeeList;
        }

        public bool UpdateEmployee(Employee employeeObject)
        {
            Connection();
            SqlCommand sqlCommand = new SqlCommand("UpdateEmployeeDetails", sqlConnection);

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", employeeObject.Id);
            sqlCommand.Parameters.AddWithValue("@FullName", employeeObject.FullName);
            sqlCommand.Parameters.AddWithValue("@Email", employeeObject.Email);
            sqlCommand.Parameters.AddWithValue("@Address", employeeObject.Address);
            sqlCommand.Parameters.AddWithValue("@Password", employeeObject.Password);

            sqlConnection.Open();
            int affectedRecords = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            if (affectedRecords >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteEmployee(int Id)
        {
            Connection();
            SqlCommand sqlCommand = new SqlCommand("DeleteEmployee", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", Id);

            sqlConnection.Open();
            int affectedRecords = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

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
