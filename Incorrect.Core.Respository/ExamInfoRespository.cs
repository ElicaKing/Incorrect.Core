using Incorrect.Core.Common;
using Incorrect.Core.IRespository;
using Incorrect.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Incorrect.Core.Respository
{
    public class ExamInfoRespository : BaseRespository<Exam_Info>, IExamInfoRespository
    {
        public ExamInfoRespository(MyDbContext myDbContext) : base(myDbContext)
        {
        }
    }
}
