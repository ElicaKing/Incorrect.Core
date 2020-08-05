using Incorrect.Core.IRespository;
using Incorrect.Core.IService;
using Incorrect.Core.Model;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Incorrect.Core.Service
{
    public class ExamInfoService : BaseService<Exam_Info>, IExamInfoService
    {
        public readonly IBaseRepository<Exam_Info> repository;
        public ExamInfoService(IUnitOfWork unitOfWork, IBaseRepository<Exam_Info> currentRepository) : base(unitOfWork, currentRepository)
        {
            this.repository = currentRepository;
        }
    }
}
