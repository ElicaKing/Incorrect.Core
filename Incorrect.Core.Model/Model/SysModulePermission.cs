using System;
using System.Collections.Generic;
namespace Incorrect.Core
{
    public  class SysModulePermission
    {
        public int ID { get; set; }
        public int ModuleID { get; set; }
        public int PermissionId { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}
