using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class SchoolUserRelation_Info
    {
        public int ID { get; set; }
        public Nullable<int> OrganID { get; set; }
        public Nullable<int> SchoolClassID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> UserRelationType { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
    }
}
