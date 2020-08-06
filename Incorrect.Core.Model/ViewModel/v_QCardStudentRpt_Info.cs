using System;
using System.Collections.Generic;
namespace Incorrect.Core
{
    public  class v_QCardStudentRpt_Info
    {
        public int ID { get; set; }
        public string RecGuid { get; set; }
        public Nullable<int> OrganID { get; set; }
        public Nullable<int> QcardID { get; set; }
        public Nullable<int> StudentID { get; set; }
        public Nullable<int> PracticeQID { get; set; }
        public Nullable<int> QuestionID { get; set; }
        public Nullable<int> SupplyQuestion { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public string QAnswer { get; set; }
        public string QAnalysis { get; set; }
        public Nullable<int> QType { get; set; }
        public string QContent { get; set; }
        public string PAnswer { get; set; }
        public string PAnalysis { get; set; }
        public Nullable<int> PType { get; set; }
        public string PContent { get; set; }
        public string ExamName { get; set; }
        public string ChapterName { get; set; }
        public string QuestionSource { get; set; }
    }
}
