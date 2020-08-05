using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class SysUserEx_Info
    {
        public int UserID { get; set; }
        public Nullable<int> Integral { get; set; }
        public Nullable<System.DateTime> VipStartDate { get; set; }
        public Nullable<System.DateTime> VipEndDate { get; set; }
        public Nullable<int> IsVip { get; set; }
    }
}
