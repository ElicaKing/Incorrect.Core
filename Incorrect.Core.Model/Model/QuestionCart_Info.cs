using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class QuestionCart_Info
    {
        public int ID { get; set; }
        public string RecGuid { get; set; }
        public Nullable<int> OrganID { get; set; }
        public Nullable<int> CourseID { get; set; }
        public Nullable<int> JoinType { get; set; }
        public Nullable<int> PracticeQID { get; set; }
        public Nullable<int> PracticeType { get; set; }
        public Nullable<int> QuestionID { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
    }
}
