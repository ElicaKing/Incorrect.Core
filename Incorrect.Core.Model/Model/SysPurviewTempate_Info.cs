using System;
using System.Collections.Generic;
namespace Incorrect.Core
{
    public  class SysPurviewTempate_Info
    {
        public int ID { get; set; }
        public Nullable<int> OrganType { get; set; }
        public Nullable<int> IsAdminRights { get; set; }
        public int PurviewID { get; set; }
        public Nullable<int> PPurviewID { get; set; }
        public string PurviewNo { get; set; }
        public string PurviewName { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
    }
}
