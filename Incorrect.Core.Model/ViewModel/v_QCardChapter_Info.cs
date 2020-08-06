using System;
using System.Collections.Generic;
namespace Incorrect.Core
{
    public  class v_QCardChapter_Info
    {
        public string ChapterName { get; set; }
        public string MainTitle { get; set; }
        public string FullResourceName { get; set; }
        public int ID { get; set; }
        public string RecGuid { get; set; }
        public Nullable<int> Chapter { get; set; }
        public Nullable<int> QCardID { get; set; }
        public Nullable<int> ExamID { get; set; }
        public Nullable<int> PageIndex { get; set; }
        public string Description { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
    }
}
