// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserController.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Threading.Tasks;
using Manager.Interface;
using Microsoft.AspNetCore.Mvc;
using Model;
using Repository.Interface;

namespace Fundoo.Controllers
{
    /// <summary>
    /// User Controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    public class UserController : ControllerBase
    {
        /// <summary>
        /// The account repository
        /// </summary>
        private IAccountRepository accountRepository;

        /// <summary>
        /// The account
        /// </summary>
        private IAccount account;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserController"/> class.
        /// </summary>
        /// <param name="accountRepository">The account repository.</param>
        /// <param name="account">The account.</param>
        public UserController(IAccountRepository accountRepository, IAccount account)
        {
            this.accountRepository = accountRepository;
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
        [HttpPost]
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
        [HttpPost]
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
    }
}