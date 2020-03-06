using Microsoft.AspNet.Identity.EntityFramework;
using Model.AdminModel;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly UserContext userContext;

        public AdminRepository(UserContext userContext)
        {
            this.userContext = userContext;
        }

        public Task AddAdmin(AdminLoginModel adminLoginModel)
        {
            AdminLoginModel admin = new AdminLoginModel()
            {
                FirstName = adminLoginModel.FirstName,
                LastName = adminLoginModel.LastName,
                Email = adminLoginModel.Email,
                Password = adminLoginModel.Password
            };
            userContext.AdminLogin.Add(admin);
            return Task.Run(() => userContext.SaveChanges());
        }

        public async Task<string> AdminLogin(AdminLoginModel adminLogin)
        {
            var result = await this.FindByEmailAsync(adminLogin.Email);
            if (result != null)
            {
                bool admin = userContext.AdminLogin.Any(r => r.Email == adminLogin.Email && r.Password == adminLogin.Password);
                if (admin)
                {
                    try
                    {
                        return "LOGIN SUCCESSFULLY";
                    }
                    catch (Exception exception)
                    {
                        throw new Exception(exception.Message);
                    }
                }
            }
            return "INVALID ADMIN DETAILS";
        }

        public Task<IdentityUser> FindByEmailAsync(string email)
        {
            AdminLoginModel admin = userContext.AdminLogin.Where(r => r.Email == email).Single();
            IdentityUser identityUser = new IdentityUser()
            {
                Email = admin.Email
            };
            return Task.Run(() => identityUser);
        }

        public List<AdminModel> GetList()
        {
            return this.userContext.Admin.ToList<AdminModel>();
        }
    }
}
