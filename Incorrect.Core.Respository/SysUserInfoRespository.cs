using Incorrect.Core.Common;
using Incorrect.Core.IRespository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Incorrect.Core.Respository
{
    public class SysUserInfoRespository : BaseRespository<SysUser_Info>, ISysUserInfoRespository
    {
        public SysUserInfoRespository(MyDbContext myDbContext) : base(myDbContext)
        {
        }
    }
}
