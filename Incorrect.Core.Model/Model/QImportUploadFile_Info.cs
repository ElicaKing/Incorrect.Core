using System;
using System.Collections.Generic;
namespace Incorrect.Core
{
    
    
    public  class QImportUploadFile_Info
    {
        public int ID { get; set; }
        public Nullable<int> ResourceType { get; set; }
        public Nullable<int> ExamID { get; set; }
        public Nullable<int> StorageType { get; set; }
        public string ImportFileName { get; set; }
        public string ImportFileFolder { get; set; }
        public Nullable<int> ImportStatus { get; set; }
        public Nullable<int> OrganID { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
    }
}
