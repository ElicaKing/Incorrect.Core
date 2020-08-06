using Incorrect.Core.IRespository;
using Incorrect.Core.IService;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Incorrect.Core.Service
{
    public class SchoolGradeService : BaseService<v_SchoolGrade_Info>, ISchoolGradeService
    {
        public readonly ISchoolGradeRespository schoolGrade;
        public SchoolGradeService(IUnitOfWork unitOfWork, IBaseRepository<v_SchoolGrade_Info> currentRepository, ISchoolGradeRespository schoolGrade) : base(unitOfWork, currentRepository)
        {
            this.schoolGrade = schoolGrade;
        }

        public async Task<object> GetTopGradeSerialIDByReader(int OrganId, Nullable<int> GradeSerialID)
        {
            if (GradeSerialID>0)  return await currentRepository.Select(c => c.OrganID.Equals(OrganId) && c.GradeSerialID.Equals(GradeSerialID));
            else
                return await schoolGrade.Select(c => c.OrganID.Equals(OrganId));
            // var topGrade =  GradeSerialID==null?  schoolGrade.Select(c=>c.OrganID.Equals(OrganId)) :  schoolGrade.Select(c => c.OrganID.Equals(OrganId) && c.GradeSerialID.Equals(GradeSerialID));
        }

    }
}
