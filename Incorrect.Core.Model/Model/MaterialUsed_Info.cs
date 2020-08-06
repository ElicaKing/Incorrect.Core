using System;
using System.Collections.Generic;
namespace Incorrect.Core
{
    public  class MaterialUsed_Info
    {
        public int ID { get; set; }
        public string RecGuid { get; set; }
        public Nullable<int> MaterialID { get; set; }
        public Nullable<int> OrganID { get; set; }
        public Nullable<int> SchoolyearID { get; set; }
        public Nullable<int> ClassTypeID { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
    }
}
