using System;
using System.Collections.Generic;
namespace Incorrect.Core
{
    public  class MaterialQuestion_Info
    {
        public int ID { get; set; }
        public Nullable<int> MaterialID { get; set; }
        public Nullable<int> ChapterID { get; set; }
        public Nullable<int> QuestionID { get; set; }
        public Nullable<int> PageNo { get; set; }
        public Nullable<int> QuestionNo { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
    }
}
