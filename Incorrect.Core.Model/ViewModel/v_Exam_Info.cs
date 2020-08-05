using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class v_Exam_Info
    {
        public int ID { get; set; }
        public string RecGuid { get; set; }
        public Nullable<int> OrganID { get; set; }
        public Nullable<int> QuestionSource { get; set; }
        public Nullable<int> ExamType { get; set; }
        public string MainTitle { get; set; }
        public string SecondTitle { get; set; }
        public Nullable<int> TotalQuestionNum { get; set; }
        public Nullable<int> TotalPageNum { get; set; }
        public Nullable<int> OwnerUserID { get; set; }
        public Nullable<int> CourseID { get; set; }
        public Nullable<int> SchoolyearID { get; set; }
        public Nullable<int> GradeSerialID { get; set; }
        public Nullable<int> Semester { get; set; }
        public Nullable<int> ProvinceID { get; set; }
        public Nullable<int> CityID { get; set; }
        public string Description { get; set; }
        public Nullable<int> UsedNum { get; set; }
        public Nullable<int> IsShare { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public Nullable<int> ExamID { get; set; }
        public Nullable<int> HasBindingline { get; set; }
        public Nullable<int> HasConfidentialMark { get; set; }
        public Nullable<int> HasStuInputColumn { get; set; }
        public Nullable<int> HasInfoColumn { get; set; }
        public Nullable<int> HasTranscribeColumn { get; set; }
        public Nullable<int> HasAttentionColumn { get; set; }
        public Nullable<int> HasBigQAttentionColumn { get; set; }
        public Nullable<int> HasBigQScoreColumn { get; set; }
        public Nullable<int> HasPaper1 { get; set; }
        public Nullable<int> HasPaper2 { get; set; }
        public Nullable<int> HasPaper3 { get; set; }
        public string PagerTitle1 { get; set; }
        public string PagerTitle2 { get; set; }
        public string PagerTitle3 { get; set; }
        public Nullable<int> HasChoiceColumn { get; set; }
        public Nullable<int> HasChoiceScore { get; set; }
        public string ChoiceTitle { get; set; }
        public string ChoiceDesc { get; set; }
        public Nullable<int> HasFillColumn { get; set; }
        public Nullable<int> HasFillScore { get; set; }
        public string FillTitle { get; set; }
        public string FillDesc { get; set; }
        public string StuInputColumn { get; set; }
        public string GradeName { get; set; }
        public string ExamTypeName { get; set; }
        public string QuestionSourceName { get; set; }
        public string StatusName { get; set; }
        public int IsUploadExam { get; set; }
        public string ExamQSource { get; set; }
        public string ExamQSourceName { get; set; }
    }
}
