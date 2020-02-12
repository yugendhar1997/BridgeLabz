// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Employee.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagement.Model
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Model class for the employee.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Gets or sets the empid.
        /// </summary>
        /// <value>
        /// The empid.
        /// </value>
        [Key]
        [Required(ErrorMessage = "Emp id is required.")]
        public int Empid { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Required(ErrorMessage = " Name is required.")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }
    }
}
