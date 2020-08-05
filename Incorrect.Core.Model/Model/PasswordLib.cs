using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class PasswordLib
    {
        public int PLID { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string plURL { get; set; }
        public string plPWD { get; set; }
        public string plAccountName { get; set; }
        public Nullable<int> plStatus { get; set; }
        public Nullable<int> plErrorCount { get; set; }
        public string plHintPwd { get; set; }
        public string plHintquestion { get; set; }
        public Nullable<System.DateTime> plCreateTime { get; set; }
        public Nullable<System.DateTime> plUpdateTime { get; set; }
        public Nullable<System.DateTime> plLastErrTime { get; set; }
        public string test { get; set; }
    }
}
