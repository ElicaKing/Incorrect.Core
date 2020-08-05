using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class SysOrganEx_Info
    {
        public int OrganID { get; set; }
        public string LogoBannerPath { get; set; }
        public Nullable<int> AuthenticationMode { get; set; }
        public string WechatCodePath { get; set; }
        public string DefPassword { get; set; }
    }
}
