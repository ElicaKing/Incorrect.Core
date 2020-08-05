using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Incorrect.Core.IService
{
    public interface ISchoolGradeService:IBaseService<v_SchoolGrade_Info>
    {
        /// <summary>
        /// 获取年级数据
        /// </summary>
        /// <param name="OrganId"></param>
        /// <returns></returns>
        Task<object>  GetTopGradeSerialIDByReader(int OrganId,Nullable<int> GradeSerialID);
    }
}
