using System;
using System.Collections.Generic;
namespace Incorrect.Core
{
    public  class SysBaseDetail_Info
    {
        public int ID { get; set; }
        public Nullable<int> OrganType { get; set; }
        public string MainNo { get; set; }
        public string ParentNo { get; set; }
        public string DetailNo { get; set; }
        public string DetailName { get; set; }
        public string Description { get; set; }
        public Nullable<int> IsDefault { get; set; }
        public Nullable<decimal> ProfitSharing { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> OrganID { get; set; }
        public int Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
    }
}
