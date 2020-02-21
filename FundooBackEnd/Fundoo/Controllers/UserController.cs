using System;
using System.Threading.Tasks;
using Manager.Interface;
using Microsoft.AspNetCore.Mvc;
using Model;
using Repository.Connections;
using Repository.Interface;
using Repository.Repository;

namespace Fundoo.Controllers
{
    public class UserController : ControllerBase
    {

        private Connection connection = new Connection();
        private IAccountRepository accountRepository;
        private IAccount account;

        public UserController(IAccountRepository accountRepository, IAccount account)
        {
            this.accountRepository = accountRepository;
            this.account = account;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {
            try
            {
                var result = await this.account.LoginAsync(loginModel);

                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Registration([FromBody] UserModels models)
        {
            try
            {
                // connection.Add(models);
                var result = await this.account.RegistrationAsync(models);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("forget")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgetPasswordModel model)
        {
            try
            {
                var result = await this.account.ForgetPassword(model);

                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("reset")]
        public async Task<ActionResult> ResetPassword([FromBody]ResetPasswordModel resetPasswordModel)
        {
            try
            {
                var result = await this.account.ResetPassword(resetPasswordModel);

                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("fblogin")]
        public async Task<IActionResult> FaceBookLogin([FromBody] string Email)
        {
            try
            {
                var result = await this.account.FaceBookLoginAsync(Email);

                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //[HttpPost]
        //[Route("fblogin")]
        //public async Task<IActionResult> FaceBookLogin([FromBody]string Email)
        //{
        //    try
        //    {
        //        var result = await this.account.FaceBookLoginAsync(Email);
        //        AdminModel model = new AdminModel();
        //        model.Email = Email;
        //        DateTime time = DateTime.Now;
        //        model.LoginTime = time.ToString();
        //        admin.Add(model);
        //        if (result == "invalid user")
        //        {
        //            return this.BadRequest();
        //        }
        //        else
        //        {
        //            return this.Ok(new { result });
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        return this.BadRequest(e.Message);
        //    }
        //}


    }
}
