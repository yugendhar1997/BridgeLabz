// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar"/>
// --------------------------------------------------------------------------------------------------------------------

using EmployeeManagement.Manager;
using EmployeeManagement.Model;
using EmployeeManagement.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using FromBodyAttribute = System.Web.Http.FromBodyAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace EmployeeManagement
{
    /// <summary>
    /// Controller class for performing CRUD operations.
    /// </summary>
    //[Route("api/[controller]")]
    //[ApiController]
    public class EmployeeController : ControllerBase
    {
        private  IEmployeeManager empManager;

        public EmployeeController(IEmployeeManager empManager)
        {
            this.empManager = empManager;
        }

       
        /// <summary>
        /// To get all employees from the database.
        /// </summary>
        /// <returns></returns>
        //[HttpGet]
        [Route("Show")]
        public ActionResult GetAllEmpDetails()
        {
            try
            {
                var result = empManager.Retrieve();
                return Ok(result);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        /// <summary>
        /// To add an employee to the database
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/Create")]
        public IActionResult AddEmployee(Employee emp)
        {
            try
            {
                var result = empManager.Add(emp);
                return Ok(new { result });

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }    
        
        /// <summary>
        /// To edit details of the specified employee
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>    
        [HttpPost]
        [Route("Update")]
        public ActionResult EditEmpDetails(Employee emp)
        {
            try
            {
                var result = empManager.Update(emp);
                return Ok(result);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// To delete employee of the specifies id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]  
        [Route("Delete")]
        public ActionResult DeleteEmp(int id)
        {
            try
            {
                var result = empManager.Delete(id);
                return Ok( result );

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
