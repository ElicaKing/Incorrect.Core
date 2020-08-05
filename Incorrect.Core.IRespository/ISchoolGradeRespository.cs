using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Incorrect.Core.IRespository
{
    public interface ISchoolGradeRespository:IBaseRepository<v_SchoolGrade_Info>
    {
       Task<string> GetTopGradeSerialIDByReader(int OrganId);
    }
}
