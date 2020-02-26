// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAccountRepository.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IAccountRepository
    {
        /// <summary>
        /// Logins the asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        Task<string> LoginAsync(LoginModel loginModel);

        /// <summary>
        /// Resets the password asynchronous.
        /// </summary>
        /// <param name="resetPasswordModel">The reset password model.</param>
        /// <returns></returns>
        Task ResetPasswordAsync(ResetPasswordModel resetPasswordModel);

        /// <summary>
        /// Creates the asynchronous.
        /// </summary>
        /// <param name="userModel">The user model.</param>
        /// <returns></returns>
        Task CreateAsync(UserModels userModel);

        /// <summary>
        /// Forgets the password asynchronous.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        Task<string> ForgetPasswordAsync(ForgetPasswordModel model);

        /// <summary>
        /// Facebook login asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        Task<string> FaceBookLoginAsync(LoginModel loginModel);

        /// <summary>
        /// Google login asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        Task<string> GoogleLoginAsync(LoginModel loginModel);

        /// <summary>
        /// Logouts the specified login model.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        string Logout(LoginModel loginModel);
    }
}