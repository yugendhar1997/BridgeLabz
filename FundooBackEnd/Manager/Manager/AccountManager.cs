// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountManager.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
using Manager.Interface;
using Model;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Manager
{
    public class AccountManager : IAccount
    {
        /// <summary>
        /// The context
        /// </summary>
        private readonly IAccountRepository context;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountManager"/> class.
        /// </summary>
        public AccountManager()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountManager"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public AccountManager(IAccountRepository context)
        {
            this.context = context;
        }

        /// <summary>
        /// Logins the asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        public Task<string> LoginAsync(LoginModel loginModel)
        {
            var result = this.context.LoginAsync(loginModel);
            return result;
        }

        /// <summary>
        /// Registrations the asynchronous.
        /// </summary>
        /// <param name="userModel">The user model.</param>
        /// <returns></returns>
        public async Task<bool> RegistrationAsync(UserModels userModel)
        {
            await this.context.CreateAsync(userModel);
            return true;
        }

        /// <summary>
        /// Resets the password.
        /// </summary>
        /// <param name="resetPasswordModel">The reset password model.</param>
        /// <returns></returns>
        public async Task<bool> ResetPassword(ResetPasswordModel resetPasswordModel)
        {
            await this.context.ResetPasswordAsync(resetPasswordModel);
            return true;
        }

        /// <summary>
        /// Forgets the password.
        /// </summary>
        /// <param name="resetPasswordModel">The reset password model.</param>
        /// <returns></returns>
        public async Task<bool> ForgetPassword(ForgetPasswordModel resetPasswordModel)
        {
            await this.context.ForgetPasswordAsync(resetPasswordModel);
            return true;
        }

        /// <summary>
        /// Faces the book login asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        public Task<string> FaceBookLoginAsync(LoginModel loginModel)
        {
            var result = this.context.FaceBookLoginAsync(loginModel);
            return result;
        }
    }
}

