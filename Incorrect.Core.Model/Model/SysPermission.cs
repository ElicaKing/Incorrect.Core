using System;
using System.Collections.Generic;
namespace Incorrect.Core
{
    public  class SysPermission
    {
        public int ID { get; set; }
        public int PPermissionID { get; set; }
        public string PermissionAction { get; set; }
        public string PermissionTitle { get; set; }
        public int IsButton { get; set; }
        public Nullable<int> IsHide { get; set; }
        public string Func { get; set; }
        public int Mid { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public int SortID { get; set; }
        public int Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
    }
}
