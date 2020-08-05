using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class SysWechatContact_Info
    {
        public int ID { get; set; }
        public string RecGuid { get; set; }
        public Nullable<int> BindingType { get; set; }
        public string WeChatOpenID { get; set; }
        public string ToUserName { get; set; }
        public string UnionID { get; set; }
        public Nullable<int> OrganID { get; set; }
        public Nullable<int> GroupID { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime EditTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> Subscribe { get; set; }
        public string NickName { get; set; }
        public string Sex { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string Language { get; set; }
        public string Headimgurl { get; set; }
        public Nullable<System.DateTime> Subscribe_time { get; set; }
        public Nullable<System.DateTime> UnSubscribe_time { get; set; }
        public string Remark { get; set; }
        public string Tagid_list { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Precision { get; set; }
        public Nullable<System.DateTime> locationtime { get; set; }
    }
}
