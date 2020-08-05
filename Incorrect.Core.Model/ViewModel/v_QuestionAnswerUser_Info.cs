using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class v_QuestionAnswerUser_Info
    {
        public int ID { get; set; }
        public string RecGuid { get; set; }
        public Nullable<int> OrganID { get; set; }
        public Nullable<int> QuestionID { get; set; }
        public Nullable<int> QCardID { get; set; }
        public Nullable<int> AnswerUserID { get; set; }
        public Nullable<int> IsError { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public Nullable<int> SchoolClassID { get; set; }
        public string GradeClassName { get; set; }
        public Nullable<int> GradeSerialID { get; set; }
        public Nullable<int> SchoolyearID { get; set; }
        public string UserName { get; set; }
        public Nullable<int> ChapterID { get; set; }
        public Nullable<int> ExamID { get; set; }
    }
}
