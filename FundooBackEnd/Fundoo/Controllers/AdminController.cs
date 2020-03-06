using Manager.Interface;
using Microsoft.AspNetCore.Mvc;
using Model.AdminModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundoo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdmin admin;

        public AdminController(IAdmin admin)
        {
            this.admin = admin;
        }

        [HttpPost]
        [Route("adding")]
        public IActionResult AddAdminAsync(AdminLoginModel adminLogin)
        {
            try
            {
                var result = this.admin.AddAdminAsync(adminLogin);
                return this.Ok(new { result });
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> LoginAsync(AdminLoginModel adminLogin)
        {
            try
            {
                var result = await this.admin.AdminLoginAsync(adminLogin);
                return this.Ok(new { result });
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        [HttpGet]
        [Route("loginlist")]
        public List<AdminModel> List()
        {
            return this.admin.GetAllListAsync();
        }
    }
}
