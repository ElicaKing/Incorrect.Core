using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class ExamQuestion_Info
    {
        public int ID { get; set; }
        public string RecGuid { get; set; }
        public Nullable<int> ExamID { get; set; }
        public Nullable<int> PracticeQID { get; set; }
        public Nullable<int> PracticeType { get; set; }
        public Nullable<int> QuestionID { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
    }
}
