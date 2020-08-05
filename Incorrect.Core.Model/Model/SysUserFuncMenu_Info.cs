using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class SysUserFuncMenu_Info
    {
        public int ID { get; set; }
        public Nullable<int> OrganID { get; set; }
        public string RecGuid { get; set; }
        public Nullable<int> FuncMenuType { get; set; }
        public Nullable<int> PMenuID { get; set; }
        public string FuncRecGuid { get; set; }
        public Nullable<int> MenuType { get; set; }
        public string MenuTitle { get; set; }
        public string MenuNavigateUrl { get; set; }
        public string MenuIconStyle { get; set; }
        public string Description { get; set; }
        public Nullable<int> SubMenuNum { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> EditTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
    }
}
