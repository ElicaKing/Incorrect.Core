using System;
using System.Collections.Generic;
namespace Incorrect.Core
{
    public  class QuestionImportEx
    {
        public int ID { get; set; }
        public Nullable<int> QuestionID { get; set; }
        public string ImportFileName { get; set; }
        public Nullable<int> QNum { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public string ImportSource { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
    }
}
