using System;
using System.Collections.Generic;
namespace Incorrect.Core
{
    public class v_Material_Info
    {
        public string GradeSerialName { get; set; }
        public string SemesterName { get; set; }
        public string MaterialTypeName { get; set; }
        public string MaterialVersionName { get; set; }
        public string CreateUserName { get; set; }
        public int ID { get; set; }
        public string RecGuid { get; set; }
        public Nullable<int> OrganID { get; set; }
        public Nullable<int> CourseID { get; set; }
        public Nullable<int> GradeSerialID { get; set; }
        public Nullable<int> Semester { get; set; }
        public string MaterialName { get; set; }
        public string MaterialFullName { get; set; }
        public Nullable<int> MaterialType { get; set; }
        public string MaterialVersion { get; set; }
        public Nullable<int> PageNum { get; set; }
        public string Description { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
    }
}
