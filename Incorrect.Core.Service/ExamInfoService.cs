using Incorrect.Core.IRespository;
using Incorrect.Core.IService;

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
