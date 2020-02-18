using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Model;

namespace Fundoo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<UserModels> userManager;

        private readonly AppSetting appSettings;

        [HttpPost]
        [Route("/login")]
        public async Task<IActionResult> Login(LoginModel model)
        {
            try
            {
                var user = await this.userManager.FindByEmailAsync(model.Email);
                if (user != null && await this.userManager.CheckPasswordAsync(user, model.Password))
                {
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                    {

                          new Claim("Email",user.Email)
                    }),
                        Expires = DateTime.UtcNow.AddDays(1),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.appSettings.Secret)), SecurityAlgorithms.HmacSha256Signature)
                    };
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                    var token = tokenHandler.WriteToken(securityToken);
                    return this.Ok(new { token, user });

                }
                else
                {
                    return this.BadRequest();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IActionResult> Register(RegistrationModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return this.BadRequest(this.ModelState);
                }

                var user = new UserModels()
                {
                    FirstName = model.firstName,
                    LastName = model.lastName,
                    Email = model.emailId,
                    Password = model.password,
                };

                var result = await this.userManager.CreateAsync(user, model.password);

                return this.Ok(result);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
