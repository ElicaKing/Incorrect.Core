using System;
using System.Collections.Generic;
namespace Incorrect.Core
{
    public  class SysPicToMathAppKey_Info
    {
        public int ID { get; set; }
        public string RecGuid { get; set; }
        public Nullable<int> OrganID { get; set; }
        public string AppKey { get; set; }
        public Nullable<System.DateTime> LastUsedTime { get; set; }
        public Nullable<int> UseInterval { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<int> IsDeleted { get; set; }
    }
}
