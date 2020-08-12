using Incorrect.Core.Common;
using Incorrect.Core.IRespository;
using Incorrect.Core.IService;

namespace Incorrect.Core.Service
{
    public class ExamInfoService : BaseService<Exam_Info>, IExamInfoService
    {
        public readonly IBaseRepository<Exam_Info> repository;
        protected MyDbContext _dbContext;
        public ExamInfoService(IUnitOfWork unitOfWork, IBaseRepository<Exam_Info> currentRepository,MyDbContext dbContext) : base(unitOfWork, currentRepository)
        {
            this.repository = currentRepository;
            this._dbContext = dbContext;
        }
        //public string test() {
        //    var wew = from iaa in _dbContext.Exam_Info
        //              select iaa;
        //    return null;
        //}
    }
}
