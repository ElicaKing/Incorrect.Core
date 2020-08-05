using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class v_SysUserCourse_Info
    {
        public int ID { get; set; }
        public Nullable<int> OrganID { get; set; }
        public int UserID { get; set; }
        public int CourseID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public string CourseName { get; set; }
        public Nullable<int> SchoolType { get; set; }
        public string SchoolTypeName { get; set; }
    }
}
