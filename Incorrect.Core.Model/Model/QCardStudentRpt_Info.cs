using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class QCardStudentRpt_Info
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
    }
}
