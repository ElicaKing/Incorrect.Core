using System;
using System.Collections.Generic;
namespace Incorrect.Core.Model
{
    public  class BaseDifficultyInfo
    {
        public int ID { get; set; }
        public Nullable<int> DifficultyID { get; set; }
        public string DifficultyName { get; set; }
        public Nullable<decimal> LowerValue { get; set; }
        public Nullable<decimal> UpperValue { get; set; }
        public string IsDefault { get; set; }
        public string Description { get; set; }
        public Nullable<int> GradeSerialID { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
    }
}
