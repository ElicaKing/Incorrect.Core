using System;
using System.Collections.Generic;
namespace Incorrect.Core
{
    public  class SysUploadFileExt_Info
    {
        public int ID { get; set; }
        public string FileExt { get; set; }
        public string FileExtName { get; set; }
        public string IconName { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<System.DateTime> EditTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
    }
}
