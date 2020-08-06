using System;
using System.Collections.Generic;
namespace Incorrect.Core
{
    public  class SysUserRole_Info
    {
        public int ID { get; set; }
        public Nullable<int> OrganID { get; set; }
        public int UserID { get; set; }
        public int RoleID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> IsDeleted { get; set; }
    }
}
