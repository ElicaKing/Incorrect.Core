using Incorrect.Core.Common;
using Incorrect.Core.IRespository;

namespace Incorrect.Core.Respository
{
    public class ExamInfoRespository : BaseRespository<Exam_Info>, IExamInfoRespository
    {
        public ExamInfoRespository(MyDbContext myDbContext) : base(myDbContext)
        {
        }
    }
}
