using Incorrect.Core.Common;
using Incorrect.Core.IRespository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Incorrect.Core.Respository
{
    public class SysOrganInfoRespository : BaseRespository<SysOrgan_Info>, ISysOrganInfoRespository
    {
        public SysOrganInfoRespository(MyDbContext myDbContext) : base(myDbContext)
        {
        }
    }
}
