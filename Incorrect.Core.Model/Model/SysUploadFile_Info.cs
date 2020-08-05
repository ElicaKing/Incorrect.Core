using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class SysUploadFile_Info
    {
        public int ID { get; set; }
        public Nullable<int> OrganID { get; set; }
        public string FuncRecGuid { get; set; }
        public Nullable<int> MasterTableType { get; set; }
        public string MasterTableRecGuid { get; set; }
        public string UploadFileName { get; set; }
        public string ThumbUploadFileName { get; set; }
        public string SubCategory { get; set; }
        public string FileName { get; set; }
        public string FileExt { get; set; }
        public Nullable<int> FileSize { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> IsTop { get; set; }
        public string WechatURL { get; set; }
        public string ExtendedValue1 { get; set; }
    }
}
