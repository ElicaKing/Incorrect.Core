using System;
using System.Collections.Generic;
namespace Incorrect.Core
{
    public  class SysDeptUser_Info
    {
        public int ID { get; set; }
        public Nullable<int> OrganID { get; set; }
        public Nullable<int> DeptID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
    }
}
