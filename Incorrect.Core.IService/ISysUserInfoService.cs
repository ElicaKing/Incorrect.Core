using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Incorrect.Core.IService
{
    public interface ISysUserInfoService:IBaseService<SysUser_Info>
    {
        Task<bool> getUserInfo(string LoginCode, string Password, int SchoolYearID, int Semester);
    }
}
