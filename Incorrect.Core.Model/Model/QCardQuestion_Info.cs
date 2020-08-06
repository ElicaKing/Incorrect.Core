using System;
using System.Collections.Generic;
namespace Incorrect.Core
{
    public  class QCardQuestion_Info
    {
        public int ID { get; set; }
        public string RecGuid { get; set; }
        public Nullable<int> QCardID { get; set; }
        public Nullable<int> QuestionID { get; set; }
        public Nullable<int> PrintMark { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
    }
}
