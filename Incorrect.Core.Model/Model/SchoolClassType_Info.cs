using System;
using System.Collections.Generic;
namespace Incorrect.Core
{
    public  class SchoolClassType_Info
    {
        public int ID { get; set; }
        public string RecGuid { get; set; }
        public Nullable<int> OrganID { get; set; }
        public Nullable<int> GradeSerialID { get; set; }
        public Nullable<int> SchoolyearID { get; set; }
        public string ClassTypeName { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
    }
}
