using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class v_QuestionKnowledge_Info
    {
        public int ID { get; set; }
        public string RecGuid { get; set; }
        public Nullable<int> OrganID { get; set; }
        public Nullable<int> QuestionID { get; set; }
        public Nullable<int> KnowledgeID { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public string KnowledgeNo { get; set; }
        public string KnowledgeName { get; set; }
    }
}
