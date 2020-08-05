using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class MaterialChapter_Info
    {
        public int ID { get; set; }
        public string RecGuid { get; set; }
        public Nullable<int> MaterialID { get; set; }
        public Nullable<int> PChapterID { get; set; }
        public string ChapterNo { get; set; }
        public string ChapterName { get; set; }
        public Nullable<int> MinPageNo { get; set; }
        public Nullable<int> MaxPageNo { get; set; }
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
