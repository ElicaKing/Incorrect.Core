using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class v_SysOrgan_info
    {
        public int ID { get; set; }
        public string RecGuid { get; set; }
        public Nullable<int> POrganID { get; set; }
        public Nullable<int> OrganType { get; set; }
        public string OrganLevel { get; set; }
        public string OrganNo { get; set; }
        public string OrganName { get; set; }
        public string OrganFullName { get; set; }
        public Nullable<int> ChargeMode { get; set; }
        public string ProvinceNo { get; set; }
        public string CountryNo { get; set; }
        public string CityNo { get; set; }
        public string Description { get; set; }
        public Nullable<int> WeChatOrganID { get; set; }
        public Nullable<int> WeChatPayOrganID { get; set; }
        public string ThumbFile { get; set; }
        public string WebsiteUrl { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public string OrganTypeName { get; set; }
        public string CreateUserName { get; set; }
        public string TopFilePath { get; set; }
        public string TopThumbFilePath { get; set; }
    }
}
