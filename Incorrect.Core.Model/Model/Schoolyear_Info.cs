using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class Schoolyear_Info
    {
        public int ID { get; set; }
        public string RecGuid { get; set; }
        public Nullable<int> SchoolyearID { get; set; }
        public string SchoolyearName { get; set; }
        public string Description { get; set; }
        public Nullable<int> IsActive { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
    }
}
