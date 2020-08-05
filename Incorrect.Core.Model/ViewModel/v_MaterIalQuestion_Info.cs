using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class v_MaterIalQuestion_Info
    {
        public string QRecGuid { get; set; }
        public string QuestionContent { get; set; }
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
