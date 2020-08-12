using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Incorrect.Core.Common;
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
        /// <summary>
        /// 获取登陆人信息
        /// </summary>
        /// <param name="LoginCode">登录账号</param>
        /// <param name="Password">密码</param>
        /// <returns></returns>
        [HttpPost]
        [Route("getLoginUserInfo")]
        public async Task<Response<string>> getLoginUserInfo(string LoginCode, string Password) {
            var userInfo = await _sysUser.getUserInfo(LoginCode, Password);
            if (userInfo != null) return new Response<string> {Code=200,Message="true" };
            else 
                return new Response<string> { Code = 500, Message = "false" }; ;

        }
        /// <summary>
        /// 获取所有用户
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("GetResult")]
        public IEnumerable<SysUser_Info> GetResult() {
            return _sysUser.getUsers();
        }
        /// <summary>
        /// 根据Id获取用户数据
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns></returns>
        [HttpPost]
        [Route("getUserById")]
        public async Task<string> getUserById(int id) {
            var userInfo = await _sysUser.GetUserById(id);
            if (userInfo != null) return new Response<SysUser_Info> { Code = 200, Message = "operate success", Data = userInfo }.ToJson();
            else
                return new Response<string> { Code = 500, Message = "operate fail" }.ToJson();
        }
    }
}
