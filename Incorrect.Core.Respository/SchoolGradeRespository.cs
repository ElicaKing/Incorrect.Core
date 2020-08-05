using Incorrect.Core.Common;
using Incorrect.Core.IRespository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Incorrect.Core.Respository
{
    public class SchoolGradeRespository : BaseRespository<v_SchoolGrade_Info>, ISchoolGradeRespository
    {
        public SchoolGradeRespository(MyDbContext myDbContext) : base(myDbContext)
        {
        }
        public Task<string> GetTopGradeSerialIDByReader(int OrganId)
        {
            throw new NotImplementedException();
        }

        //public Task<string> GetTopGradeSerialIDByReader(int OrganId)
        //{
        //    var topGrade = 
        //}
    }
}
