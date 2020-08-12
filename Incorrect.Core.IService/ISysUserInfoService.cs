using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Incorrect.Core.IService
{
    public interface ISysUserInfoService:IBaseService<SysUser_Info>
    {
        Task<SysUser_Info> getUserInfo(string LoginCode, string Password);
        Task<SysUser_Info> UpdateUser(SysUser_Info user_Info);
        Task<SysUser_Info> InsertUser(SysUser_Info user_Info);
        IEnumerable<SysUser_Info> getUsers();
        Task<List<SysUser_Info>> GetUserById(int id);
    }
}
