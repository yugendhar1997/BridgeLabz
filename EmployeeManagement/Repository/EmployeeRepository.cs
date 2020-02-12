// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar"/>
// --------------------------------------------------------------------------------------------------------------------

using EmployeeManagement.Model;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Repository
{
    /// <summary>
    /// Repository class which contains method for CRUD operations
    /// </summary>
    /// <seealso cref="EmployeeManagement.Repository.IEmployeeRepository" />
    public class EmployeeRepository : IEmployeeRepository
    {
        private SqlConnection con;
        /// <summary>
        /// To Handle connection related activities
        /// </summary>
        private void connection()
        {
            string constr = "Server=(Localdb)\\MSSQLLocaldb;Database=EmployeeManagement;Integrated Security=True;";
            con = new SqlConnection(constr);

        }

        /// <summary>
        /// To Add Employee details to the database.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public bool AddEmployee(Employee obj)
        {

            connection();
            SqlCommand com = new SqlCommand("AddNewEmpDetails", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Empid", obj.Empid);
            com.Parameters.AddWithValue("@Name", obj.Name);
            com.Parameters.AddWithValue("@City", obj.City);
            com.Parameters.AddWithValue("@Address", obj.Address);

            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {

                return true;

            }
            else
            {

                return false;
            }


        }

        /// <summary>
        /// To view employee details with generic list.
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetAllEmployees()
        {
            connection();
            List<Employee> EmpList = new List<Employee>();
            SqlCommand com = new SqlCommand("GetEmployees", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();

            ////Bind EmpModel generic list using LINQ 
            EmpList = (from DataRow dr in dt.Rows

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
        /// To Update Employee details.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public bool UpdateEmployee(Employee obj)
        {

            connection();
            SqlCommand com = new SqlCommand("UpdateEmpDetails", con);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Empid", obj.Empid);
            com.Parameters.AddWithValue("@Name", obj.Name);
            com.Parameters.AddWithValue("@City", obj.City);
            com.Parameters.AddWithValue("@Address", obj.Address);
            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {

                return true;

            }
            else
            {

                return false;
            }


        }

        /// <summary>
        /// To delete Employee details.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        public bool DeleteEmployee(int Id)
        {

            connection();
            SqlCommand com = new SqlCommand("DeleteEmpById", con);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Empid", Id);

            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
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
