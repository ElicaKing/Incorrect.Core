using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class SysUserFunc_Info
    {
        public int ID { get; set; }
        public Nullable<int> PFuncID { get; set; }
        public string FuncRecGuid { get; set; }
        public Nullable<int> FuncType { get; set; }
        public string FuncTitle { get; set; }
        public string FuncTemplateNo { get; set; }
        public string Description { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime EditTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> TopStatus { get; set; }
        public Nullable<System.DateTime> TopTime { get; set; }
        public Nullable<int> OrganID { get; set; }
        public Nullable<int> SubFuncNum { get; set; }
        public string WechatPage { get; set; }
        public string ThumbImageFile { get; set; }
        public string WechatTitle { get; set; }
        public Nullable<int> FuncIsHide { get; set; }
        public string TemplateMessageID { get; set; }
        public string DefaultThumbFileName { get; set; }
        public string DefaultThumbFileMediaID { get; set; }
        public Nullable<int> IntegralByCreate { get; set; }
        public Nullable<int> IntegralByRead { get; set; }
        public Nullable<int> DailyLimit { get; set; }
        public string FuncIconStyle { get; set; }
        public string RollingFuncRecGuid { get; set; }
        public string TopFuncRecGuid { get; set; }
        public Nullable<int> IsRollingShow { get; set; }
        public Nullable<int> IsTopShow { get; set; }
        public Nullable<int> IsHideFooter { get; set; }
        public Nullable<int> IsHeaderOnlyTitle { get; set; }
        public string PageLayoutStyle { get; set; }
        public Nullable<int> WechatIsHide { get; set; }
        public Nullable<int> IsClassCard { get; set; }
    }
}
