// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountController.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
using Manager.Interface;
using Microsoft.AspNetCore.Mvc;
using Model;
using Repository.Interface;
using System;
using System.Threading.Tasks;

namespace Fundoo.Controllers
{
    /// <summary>
    /// User Controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        /// <summary>
        /// The account repository
        /// </summary>
        private readonly IAccountRepository accountRepository;

        /// <summary>
        /// The account
        /// </summary>
        private readonly IAccount account;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountController"/> class.
        /// </summary>
        /// <param name="accountRepository">The account repository.</param>
        /// <param name="account">The account.</param>
        public AccountController( IAccount account)
        {
            this.account = account;
        }

        /// <summary>
        /// Logins the specified login model.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {
            try
            {
                var result = await this.account.LoginAsync(loginModel);

                return Ok(result);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// Registrations the specified models.
        /// </summary>
        /// <param name="models">The models.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Registration([FromBody] UserModels models)
        {
            try
            {
                var result = await this.account.RegistrationAsync(models);
                return this.Ok(new { result });
            }
            catch (Exception exception)
            {
                return this.BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// Forgot password.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("forget")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgetPasswordModel model)
        {
            try
            {
                var result = await this.account.ForgetPassword(model);

                return Ok(result);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// Resets the password.
        /// </summary>
        /// <param name="resetPasswordModel">The reset password model.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("reset")]
        public async Task<ActionResult> ResetPassword([FromBody]ResetPasswordModel resetPasswordModel)
        {
            try
            {
                var result = await this.account.ResetPassword(resetPasswordModel);

                return Ok(result);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// Facebook login.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("fblogin")]
        public async Task<IActionResult> FaceBookLogin([FromBody] LoginModel loginModel)
        {
            try
            {
                var result = await this.account.FaceBookLoginAsync(loginModel);

                return Ok(result);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// Google login.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("google")]
        public async Task<IActionResult> GoogleLogin(LoginModel loginModel)
        {
            try
            {
                var result = await this.account.GoogleLoginAsync(loginModel);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Logouts the specified login model.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("logout")]
        public string Logout(LoginModel loginModel)
        {
            var result = this.account.LogoutAsync(loginModel);
            return result;
        }
    }
}