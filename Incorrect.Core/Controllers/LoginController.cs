using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Incorrect.Core.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Incorrect.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public ISysUserInfoService _sysUser;
        public LoginController(ISysUserInfoService sysUser) {
            this._sysUser = sysUser;
        }
        [HttpPost]
        [Route("getLoginUserInfo")]
        public async Task<bool> getLoginUserInfo(string LoginCode, string Password, int SchoolYearID, int Semester) {
            var userInfo = await _sysUser.getUserInfo(LoginCode, Password, SchoolYearID, Semester);
            //if (userInfo) { }
            return true;
        }
    }
}
