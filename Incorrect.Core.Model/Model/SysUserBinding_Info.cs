using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class SysUserBinding_Info
    {
        public int ID { get; set; }
        public string RecGuid { get; set; }
        public Nullable<int> OrganID { get; set; }
        public Nullable<int> BindingType { get; set; }
        public Nullable<int> BindingUserID { get; set; }
        public Nullable<int> BindingIdentity { get; set; }
        public string WechatOpenID { get; set; }
        public string WechatMobileNo { get; set; }
        public Nullable<int> IsDefault { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDelete { get; set; }
    }
}
