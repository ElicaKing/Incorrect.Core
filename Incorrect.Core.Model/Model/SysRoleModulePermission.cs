using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class SysRoleModulePermission
    {
        public int ID { get; set; }
        public int RoleID { get; set; }
        public int ModuleID { get; set; }
        public Nullable<int> PermissionID { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
    }
}
