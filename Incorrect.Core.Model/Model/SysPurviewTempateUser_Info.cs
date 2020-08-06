using System;
using System.Collections.Generic;
namespace Incorrect.Core
{
    public  class SysPurviewTempateUser_Info
    {
        public int ID { get; set; }
        public Nullable<int> OrganType { get; set; }
        public Nullable<int> OrganID { get; set; }
        public Nullable<int> PPurviewID { get; set; }
        public string FuncTemplateNo { get; set; }
        public Nullable<int> PFuncPurviewID { get; set; }
        public Nullable<int> FuncPurviewID { get; set; }
        public string FuncPurviewName { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
    }
}
