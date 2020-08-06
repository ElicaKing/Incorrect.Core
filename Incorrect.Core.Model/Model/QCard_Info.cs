using System;
using System.Collections.Generic;
namespace Incorrect.Core
{
    public  class QCard_Info
    {
        public int ID { get; set; }
        public string RecGuid { get; set; }
        public Nullable<int> ClassTypeID { get; set; }
        public Nullable<int> OrganID { get; set; }
        public Nullable<int> CourseID { get; set; }
        public Nullable<int> SchoolyearID { get; set; }
        public Nullable<int> GradeID { get; set; }
        public Nullable<int> Semester { get; set; }
        public Nullable<int> week { get; set; }
        public string ReportName { get; set; }
        public string QCardName { get; set; }
        public Nullable<int> IsChooseQuestion { get; set; }
        public Nullable<int> IsGenerateQCard { get; set; }
        public Nullable<int> IsGenerateReport { get; set; }
        public Nullable<int> GenerateType { get; set; }
        public Nullable<int> ExamID { get; set; }
        public Nullable<int> GoodExamID { get; set; }
        public Nullable<int> IsPrintShareExam { get; set; }
        public Nullable<int> PrintingMode { get; set; }
        public Nullable<int> ErrorQNum { get; set; }
        public Nullable<int> PracticeQNum { get; set; }
        public Nullable<int> matchCountSelect { get; set; }
        public Nullable<int> isPrintAnalysis { get; set; }
        public Nullable<int> HasError { get; set; }
        public Nullable<int> HasAnswer { get; set; }
        public Nullable<int> HasPractice { get; set; }
        public Nullable<int> HasPracticeAnswer { get; set; }
        public Nullable<int> HasClassErrRate { get; set; }
        public Nullable<int> HasGradeErrRate { get; set; }
        public Nullable<int> BigQuestionNum { get; set; }
        public string Description { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
    }
}
