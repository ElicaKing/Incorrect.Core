using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class v_SysUserGrade_Info
    {
        public Nullable<int> UserID { get; set; }
        public int ID { get; set; }
        public string RecGuid { get; set; }
        public Nullable<int> OrganID { get; set; }
        public Nullable<int> GradeSerialID { get; set; }
        public string SchoolGradeName { get; set; }
        public string SchoolDescription { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public string GradeName { get; set; }
        public string Description { get; set; }
        public Nullable<int> PSortID { get; set; }
        public string SchoolTypeName { get; set; }
        public Nullable<int> SchoolType { get; set; }
    }
}
