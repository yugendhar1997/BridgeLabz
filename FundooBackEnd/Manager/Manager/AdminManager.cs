using Manager.Interface;
using Model.AdminModel;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Manager
{
    public class AdminManager : IAdmin
    {
        private readonly IAdminRepository adminRepository;

        public AdminManager(IAdminRepository adminRepository)
        {
            this.adminRepository = adminRepository;
        }

        public Task AddAdminAsync(AdminLoginModel adminLogin)
        {
            try
            {
                var result = this.adminRepository.AddAdmin(adminLogin);
                return result;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public async Task<string> AdminLoginAsync(AdminLoginModel adminLogin)
        {
            try
            {
                var result = await this.adminRepository.AdminLogin(adminLogin);
                return result;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public List<AdminModel> GetAllListAsync()
        {
            try
            {
                var list = new List<AdminModel>();
                var result = this.adminRepository.GetList();
                foreach (var item in result)
                {
                    list.Add(item);
                }
                return list;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
