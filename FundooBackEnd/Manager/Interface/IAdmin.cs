using Model.AdminModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Interface
{
    public interface IAdmin
    {
        Task AddAdminAsync(AdminLoginModel adminLogin);
        Task<string> AdminLoginAsync(AdminLoginModel adminLogin);

        List<AdminModel> GetAllListAsync();
    }
}
