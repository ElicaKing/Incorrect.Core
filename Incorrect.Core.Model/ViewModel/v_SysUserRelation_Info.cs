using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class v_SysUserRelation_Info
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
        public string UserNamePy { get; set; }
        public string CreateUserName { get; set; }
        public string StatusName { get; set; }
        public string DepartmentName { get; set; }
        public string SexName { get; set; }
        public string StudentTypeName { get; set; }
        public int Integral { get; set; }
        public string TopFilePath { get; set; }
        public string TopThumbFilePath { get; set; }
        public Nullable<System.DateTime> VipStartDate { get; set; }
        public Nullable<System.DateTime> VipendDate { get; set; }
        public int IsVip { get; set; }
        public string UserTypeName { get; set; }
        public int UserRelationID { get; set; }
        public Nullable<int> SchoolClassID { get; set; }
        public Nullable<int> UserRelationType { get; set; }
        public string ClassName { get; set; }
        public Nullable<int> SchoolyearID { get; set; }
        public Nullable<int> GradeSerialID { get; set; }
        public string GradeName { get; set; }
        public string GradeClassName { get; set; }
        public string ClassFullName { get; set; }
    }
}
