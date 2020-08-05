using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class Exam_Info
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
    }
}
