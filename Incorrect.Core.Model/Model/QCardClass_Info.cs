using System;
using System.Collections.Generic;
namespace Incorrect.Core
{
    public  class QCardClass_Info
    {
        public int ID { get; set; }
        public string RecGuid { get; set; }
        public Nullable<int> QCardID { get; set; }
        public Nullable<int> ClassID { get; set; }
        public Nullable<int> GenerateType { get; set; }
        public Nullable<int> ExamID { get; set; }
        public Nullable<int> PrintingMode { get; set; }
        public Nullable<int> ErrorQNum { get; set; }
        public Nullable<int> PracticeQNum { get; set; }
        public Nullable<int> matchCountSelect { get; set; }
        public Nullable<int> isPrintAnalysis { get; set; }
        public Nullable<int> IsGenerateReport { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
    }
}
