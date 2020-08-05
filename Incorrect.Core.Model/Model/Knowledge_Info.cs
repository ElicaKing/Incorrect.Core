using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class Knowledge_Info
    {
        public int ID { get; set; }
        public string RecGuid { get; set; }
        public Nullable<int> OrganID { get; set; }
        public Nullable<int> CourseID { get; set; }
        public Nullable<int> PKnowledgeID { get; set; }
        public string KnowledgeNo { get; set; }
        public string KnowledgeName { get; set; }
        public string Description { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
    }
}
