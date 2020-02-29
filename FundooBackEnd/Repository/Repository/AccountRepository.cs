// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountRepository.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.IdentityModel.Tokens;
using Model;
using Repository.Interface;
using StackExchange.Redis;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Mail;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Repository.Repository
{
    /// <summary>
    /// Account Repository Class
    /// </summary>
    /// <seealso cref="Repository.Interface.IAccountRepository" />
    public class AccountRepository : IAccountRepository
    {
        /// <summary>
        /// The context
        /// </summary>
        private readonly UserContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountRepository"/> class.
        /// </summary>
        public AccountRepository()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="applicationSettings">The application settings.</param>
        public AccountRepository(UserContext context)
        {
            this.context = context;

        }

        /// <summary>
        /// Creates the asynchronous.
        /// </summary>
        /// <param name="userModel">The user model.</param>
        /// <returns></returns>
        public Task CreateAsync(UserModels userModel)
        {
            UserModels userDbModel = new UserModels()
            {
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                Email = userModel.Email,
                Password = userModel.Password
            };
            this.context.UserData.Add(userDbModel);
            return Task.Run(() => context.SaveChanges());
        }

        /// <summary>
        /// Logins the asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        public async Task<string> LoginAsync(LoginModel loginModel)
        {
            var user = FindByEmailAsync(loginModel.Email);
            if (user != null && await CheckPasswordAsync(loginModel.Password, loginModel.Email))
            {
                try
                {
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                       new Claim("Email" ,loginModel.Email)
                        }),
                        Expires = DateTime.UtcNow.AddDays(1),
                    };
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                    var token = tokenHandler.WriteToken(securityToken);
                    var cacheKey = loginModel.Email;
                    return token;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
            return "INVALID USER";
        }

        /// <summary>
        /// Checks the password asynchronous.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <param name="email"></param>
        /// <returns></returns>
        public Task<bool> CheckPasswordAsync(string password, string email)
        {
            bool obj = context.UserData.Where(userName => userName.Password == password && userName.Email == email).SingleOrDefault().Email == email ? true : false;

            return Task.Run(() => obj);
        }

        /// <summary>
        /// Resets the password asynchronous.
        /// </summary>
        /// <param name="resetPasswordModel">The reset password model.</param>
        /// <returns></returns>
        public Task ResetPasswordAsync(ResetPasswordModel resetPasswordModel)
        {
            UserModels obj = context.UserData.Where(userName => userName.Email == resetPasswordModel.Email).SingleOrDefault();
            obj.Password = resetPasswordModel.Password;
            var person = context.UserData.Find(resetPasswordModel.Email);
            person.Password = resetPasswordModel.Password;
            return Task.Run(() => context.SaveChanges());
        }

        /// <summary>
        /// Finds the by email asynchronous.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public Task FindByEmailAsync(string email)
        {
            UserModels user = context.UserData.Where(obj => obj.Email == email).SingleOrDefault();
            IdentityUser Iuser = new IdentityUser()
            {
                Email = user.Email
            };
            return Task.Run(() => Iuser);
        }

        /// <summary>
        /// Forgets the password asynchronous.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public async Task<string> ForgetPasswordAsync(ForgetPasswordModel model)
        {
            var user = FindByEmailAsync(model.Email);
            if (user != null)
            {
                var fromAddress = new MailAddress("yugendhar1695@gmail.com");
                var fromPassword = "BAHUBALI2";
                var toAddress = new MailAddress(model.Email);
                string subject = "Reset Password";
                string body = "To reset your password click link :-  http://localhost:44388/reset";
                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential(fromAddress.Address, fromPassword)
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                    try
                    {
                        smtp.Send(message);
                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                await Task.Run(() => this.context.SaveChangesAsync());
                return "Success";
            }
            return null;
        }

        /// <summary>
        /// Faces the book login asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        public async Task<string> FaceBookLoginAsync(LoginModel loginModel)
        {
            var user = context.UserData.Where(userName => userName.Password == loginModel.Password && userName.Email == loginModel.Email).SingleOrDefault();
            if (user != null)
            {
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                        {
                        new Claim("Email", user.Email)
                        }),
                    Expires = DateTime.UtcNow.AddDays(1),
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                var token = tokenHandler.WriteToken(securityToken);
                var cacheKey = loginModel.Email;
                

                ConnectionMultiplexer connectionMulitplexer = ConnectionMultiplexer.Connect("127.0.0.1:6379");
                IDatabase database = connectionMulitplexer.GetDatabase();
                database.StringSet(cacheKey, token.ToString());
                database.StringGet(cacheKey);
                return token;
            }

            else
            {
                UserModels models = new UserModels();
                models.Email = loginModel.Email;
                models.Password = "12345678";
                models.FirstName = null;
                models.LastName = null;
                context.UserData.Add(models);
                context.SaveChanges();
                var users = FindByEmailAsync(loginModel.Email);
                if (users != null)
                {
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                            {
                        new Claim("Email", models.Email)
                            }),
                        Expires = DateTime.UtcNow.AddDays(1),
                    };
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                    var token = tokenHandler.WriteToken(securityToken);
                    var cacheKey = loginModel.Email;
                    return token;
                }
            }
            await this.context.SaveChangesAsync();
            return "INVALID USER";
        }

        /// <summary>
        /// Google login asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        public async Task<string> GoogleLoginAsync(LoginModel loginModel)
        {
            var user = context.UserData.Where(userName => userName.Password == loginModel.Password && userName.Email == loginModel.Email).SingleOrDefault();
            if (user != null)
            {
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                        {
                        new Claim("Email", user.Email)
                        }),
                    Expires = DateTime.UtcNow.AddDays(1),
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                var token = tokenHandler.WriteToken(securityToken);
                var cacheKey = loginModel.Email;
                return token;
            }

            else
            {
                UserModels models = new UserModels();
                models.Email = loginModel.Email;
                models.Password = "12345678";
                models.FirstName = null;
                models.LastName = null;
                context.UserData.Add(models);
                context.SaveChanges();
                var users = FindByEmailAsync(loginModel.Email);
                if (users != null)
                {
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                            {
                        new Claim("Email", models.Email)
                            }),
                        Expires = DateTime.UtcNow.AddDays(1),
                    };
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                    var token = tokenHandler.WriteToken(securityToken);
                    var cacheKey = loginModel.Email;
                    return token;
                }
            }
            await this.context.SaveChangesAsync();
            return "INVALID USER";
        }

        /// <summary>
        /// Logouts the specified login model.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string Logout(LoginModel loginModel)
        {
            try
            {
                var cacheKey = loginModel.Email;
                ConnectionMultiplexer connectionMulitplexer = ConnectionMultiplexer.Connect("127.0.0.1:6379");
                StackExchange.Redis.IDatabase database = connectionMulitplexer.GetDatabase();

                database.KeyDelete(cacheKey);
                return "LOGOUT SUCCESSFULLY";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
