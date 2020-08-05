using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class v_SysRole_info
    {
        public int ID { get; set; }
        public Nullable<int> OrganType { get; set; }
        public string RecGuid { get; set; }
        public Nullable<int> OrganID { get; set; }
        public Nullable<int> UserType { get; set; }
        public Nullable<int> RoleIsDefault { get; set; }
        public string RoleNo { get; set; }
        public string RoleName { get; set; }
        public string Purview { get; set; }
        public string Description { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> EditTime { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public string UserTypeName { get; set; }
        public string CreateUserName { get; set; }
        public string OrganName { get; set; }
    }
}
