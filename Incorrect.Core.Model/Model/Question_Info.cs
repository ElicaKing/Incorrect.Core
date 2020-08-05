using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class Question_Info
    {
        public int ID { get; set; }
        public string RecGuid { get; set; }
        public Nullable<int> OrganID { get; set; }
        public Nullable<int> QuestionSource { get; set; }
        public Nullable<int> QuestionLibraryType { get; set; }
        public Nullable<int> ChapterID { get; set; }
        public Nullable<int> ExamID { get; set; }
        public Nullable<int> PageNum { get; set; }
        public Nullable<int> OwnerUserID { get; set; }
        public Nullable<int> CourseID { get; set; }
        public Nullable<int> SchoolyearID { get; set; }
        public Nullable<int> ProvinceID { get; set; }
        public Nullable<int> CityID { get; set; }
        public Nullable<int> QuestionType { get; set; }
        public Nullable<decimal> Difficulty { get; set; }
        public string QuestionContent { get; set; }
        public string QuestionAnalysis { get; set; }
        public string QuestionAnswer { get; set; }
        public string Questiondetailed { get; set; }
        public string QuestionComment { get; set; }
        public Nullable<int> NumOfRows { get; set; }
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
        public int GradeSerialID { get; set; }
    }
}
