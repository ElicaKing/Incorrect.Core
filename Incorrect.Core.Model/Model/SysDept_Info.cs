using System;
using System.Collections.Generic;
namespace Incorrect.Core
{
    public  class SysDept_Info
    {
        public int ID { get; set; }
        public Nullable<int> OrganID { get; set; }
        public Nullable<int> PDeptID { get; set; }
        public string DeptName { get; set; }
        public Nullable<int> WechatQyDeptID { get; set; }
        public Nullable<int> SynchronousToQyWechat { get; set; }
        public Nullable<System.DateTime> EditTime { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
    }
}
