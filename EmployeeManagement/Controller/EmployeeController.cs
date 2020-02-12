// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeController.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagement
{
    using EmployeeManagement.Manager;
    using EmployeeManagement.Model;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
    using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

    /// <summary>
    /// Controller class for performing CRUD operations.
    /// </summary>
    //// [Route("api/[controller]")]
    //// [ApiController]
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// The emloyee manager
        /// </summary>
        private IEmployeeManager empManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        /// <param name="empManager">The emp manager.</param>
        public EmployeeController(IEmployeeManager empManager)
        {
            this.empManager = empManager;
        }
       
        /// <summary>
        /// To get all employees from the database.
        /// </summary>
        /// <returns>All Employee Details</returns>
        ////[HttpGet]
        [Route("Show")]
        public ActionResult GetAllEmpDetails()
        {
            try
            {
                var result = empManager.Retrieve();
                return Ok(result);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// To add an employee to the database
        /// </summary>
        /// <param name="emp"></param>
        /// <returns>Added Employee</returns>
        [HttpPost]
        [Route("/Create")]
        public IActionResult AddEmployee(Employee emp)
        {
            try
            {
                var result = empManager.Add(emp);
                return Ok(new { result });
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }    
        
        /// <summary>
        /// To edit details of the specified employee
        /// </summary>
        /// <param name="emp"></param>
        /// <returns>Updated Employee</returns>    
        [HttpPost]
        [Route("Update")]
        public ActionResult EditEmpDetails(Employee emp)
        {
            try
            {
                var result = empManager.Update(emp);
                return Ok(result);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// To delete employee of the specifies id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Deleted Employee</returns>
        [HttpPost]  
        [Route("Delete")]
        public ActionResult DeleteEmp(int id)
        {
            try
            {
                var result = empManager.Delete(id);
                return Ok( result );
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
    }
}
