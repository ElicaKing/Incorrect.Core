using System;
using System.Collections.Generic;
namespace Incorrect.Core
{
    public  class SysRoleFunc_Info
    {
        public int ID { get; set; }
        public Nullable<int> OrganType { get; set; }
        public Nullable<int> OrganID { get; set; }
        public Nullable<int> RoleID { get; set; }
        public string FuncRecGuid { get; set; }
        public string FuncPurviewID { get; set; }
        public Nullable<int> SortID { get; set; }
        public int Status { get; set; }
    }
}
