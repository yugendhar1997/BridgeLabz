// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAccount.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Manager.Interface
{
    using Model;
    using System.Threading.Tasks;

    /// <summary>
    /// Account Interface
    /// </summary>
    public interface IAccount
    {
        /// <summary>
        /// Logins the asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        Task<string> LoginAsync(LoginModel loginModel);

        /// <summary>
        /// Registrations the asynchronous.
        /// </summary>
        /// <param name="userModel">The user model.</param>
        /// <returns></returns>
        Task<bool> RegistrationAsync(UserModels userModel);

        /// <summary>
        /// Forgets the password.
        /// </summary>
        /// <param name="resetModel">The reset model.</param>
        /// <returns></returns>
        Task<bool> ForgetPassword(ForgetPasswordModel resetModel);

        /// <summary>
        /// Resets the password.
        /// </summary>
        /// <param name="resetModel">The reset model.</param>
        /// <returns></returns>
        Task<bool> ResetPassword(ResetPasswordModel resetModel);

        /// <summary>
        /// Faces the book login asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        Task<string> FaceBookLoginAsync(LoginModel loginModel);
    }
}
