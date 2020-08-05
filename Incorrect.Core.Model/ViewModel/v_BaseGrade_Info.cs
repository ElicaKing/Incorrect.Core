using System;
namespace Incorrect.Core.Model
{    
    public  class v_BaseGrade_Info
    {
        public int ID { get; set; }
        public string RecGuid { get; set; }
        public Nullable<int> SchoolType { get; set; }
        public Nullable<int> GradeSerialID { get; set; }
        public string GradeName { get; set; }
        public string Description { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public string SchoolTypeName { get; set; }
        public string CreateUserName { get; set; }
    }
}
