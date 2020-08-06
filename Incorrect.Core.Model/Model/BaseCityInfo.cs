using System;
using System.Collections.Generic;
namespace Incorrect.Core
{
    public  class BaseCityInfo
    {
        public int ID { get; set; }
        public string RecGuid { get; set; }
        public string PProvinceNo { get; set; }
        public string CityNo { get; set; }
        public string CityName { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
    }
}
