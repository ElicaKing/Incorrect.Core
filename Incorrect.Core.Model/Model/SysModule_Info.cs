using System;
using System.Collections.Generic;
namespace Incorrect.Core
{
    public  class SysModule_Info
    {
        public int ID { get; set; }
        public Nullable<int> OrganType { get; set; }
        public Nullable<int> PurviewTag { get; set; }
        public string IconClass { get; set; }
        public string ModuleNo { get; set; }
        public string PModuleNo { get; set; }
        public string ImageUrl { get; set; }
        public string ModuleTitle { get; set; }
        public string NavigateUrl { get; set; }
        public string Target { get; set; }
        public string DefaultFuncNo { get; set; }
        public Nullable<int> Selected { get; set; }
        public string ModuleDesc { get; set; }
        public Nullable<int> IsVisible { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<System.DateTime> EditTime { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
    }
}
