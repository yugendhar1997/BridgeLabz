﻿// --------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=ControllerTest.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------------------------------------
namespace XUnitTestP.Account
{
    using BussinessManager.Interface;
    using Common.Models;
    using FundooNoteApi.Controllers;
    using Moq;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Xunit;
    /// <summary>
    /// public class for ControllerTest
    /// </summary>
    public class ControllerTest
    {
        /// <summary>
        /// Registrations this instance.
        /// </summary>
        [Fact]
        public void Registration()
        {
            var service = new Mock<IAccount>();
            var controller = new AccountController(service.Object);
            var add = new UserModel()
            {
                FirstName = "Abhishek",
                LastName = "Sharma",
                Email = "abhiz@gmail.com",
                City = "Banglore",
                Password = "pasworedeedc"
            };
            var data = controller.Registration(add);
            Assert.NotNull(data);
        }
        /// <summary>
        /// Logins this instance.
        /// </summary>
        [Fact]
        public void Login()
        {
            var service = new Mock<IAccount>();
            var controller = new AccountController(service.Object);
            var login = new LoginModel()
            {
                Email = "abhiz@gmail.com",
                Password = "pasworedeedc"
            };
            var data = controller.Login(login);
            Assert.NotNull(data);
        }
        /// <summary>
        /// Forgets the password.
        /// </summary>
        [Fact]
        public void ForgetPassword()
        {
            var service = new Mock<IAccount>();
            var controller = new AccountController(service.Object);
            var add = new ForgetPasswordModel()
            {
                Email = "abhiz@gmail.com"               
            };
            var data = controller.ForgetPassword(add);
            Assert.NotNull(data);
        }
        /// <summary>
        /// Resets the password.
        /// </summary>
        [Fact]
        public void ResetPassword()
        {
            var service = new Mock<IAccount>();
            var controller = new AccountController(service.Object);
            var add = new ResetPasswordModel()
            {
                Email = "abhiz@gmail.com",
                Password = "pasworedeedc"

            };
            var data = controller.ResetPassword(add);
            Assert.NotNull(data);
        }
    }
}
