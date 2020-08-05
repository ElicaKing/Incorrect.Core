using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class v_SchoolCourse_Info
    {
        public int ID { get; set; }
        public Nullable<int> OrganID { get; set; }
        public Nullable<int> SchoolyearID { get; set; }
        public Nullable<int> GradeSerialID { get; set; }
        public Nullable<int> CourseID { get; set; }
        public Nullable<int> IsHasFee { get; set; }
        public Nullable<decimal> SalesPrice { get; set; }
        public Nullable<decimal> PayPrice { get; set; }
        public string SchoolDescription { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> Expr1 { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public string ClassFullName { get; set; }
        public string SchoolGradeName { get; set; }
        public string GradeName { get; set; }
        public string CourseName { get; set; }
    }
}
