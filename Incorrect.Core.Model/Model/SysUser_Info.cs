using System;
using System.Collections.Generic;
namespace Incorrect.Core
{
    public  class SysUser_Info
    {
        public int ID { get; set; }
        public string RecGuid { get; set; }
        public Nullable<int> OrganID { get; set; }
        public string LoginCode { get; set; }
        public string Password { get; set; }
        public string StudentNo { get; set; }
        public string StudentCode { get; set; }
        public Nullable<int> UserType { get; set; }
        public string UserName { get; set; }
        public string MobileNo { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public Nullable<int> Sex { get; set; }
        public string Description { get; set; }
        public string ThumbIconFile { get; set; }
        public string InvitationCode { get; set; }
        public Nullable<int> StudentType { get; set; }
        public string UserRoles { get; set; }
        public Nullable<int> IsAdmin { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<System.DateTime> LastLoginTime { get; set; }
        public Nullable<int> LoginErrorCount { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public Nullable<int> IsLocking { get; set; }
    }
}
