using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Incorrect.Core.Common;
using Incorrect.Core.IService;
using Incorrect.Core;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Incorrect.Core.Controllers
{
    /// <summary>
    /// 关于学生相关信息的数据
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ExamInfoController : ControllerBase
    {
        //依赖注入
        public IExamInfoService _examInfo;
        public ISchoolGradeService _schoolGrade;
        public MyDbContext _dbContext;
        public ExamInfoController(IExamInfoService examInfo,ISchoolGradeService schoolGrade,MyDbContext dbContext)
        {
            this._examInfo = examInfo;
            this._schoolGrade = schoolGrade;
            this._dbContext = dbContext;
        }
        // GET: api/<ExamInfoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ExamInfoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ExamInfoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ExamInfoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ExamInfoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        /// <summary>
        /// 获取考生考试信息
        /// </summary>
        /// <returns></returns>
        [HttpGet,HttpPost]
        [Route("ExamInfoSelect")]
        public async Task<string> ExamInfoSelect(int ID)
        {
            try
            {
                var examInfo = await _examInfo.Select(t => t.ID.Equals(ID));
                //  var students = await studentService.Select(t => true);
                return new Response<Exam_Info>() { Data = examInfo }.ToJson();
            }
            catch (Exception e)
            {

                return new Response { Code = 500, Message = e.Message }.ToJson();
            }
        }
        /// <summary>
        /// 获取年级信息
        /// </summary>
        /// <param name="Oragan">年级ID</param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetTopGradeSerialIDByReader")]
        public async Task<object> GetTopGradeSerialIDByReader(int Oragan,int GradeSerialID) {
           var ResJson= await _schoolGrade.GetTopGradeSerialIDByReader(Oragan, GradeSerialID);
            //var wewe = _dbContext.V_SchoolGrade_Info.Where(c=>c.OrganID.Equals(Oragan)).FirstOrDefault();
            return ResJson;
        
        }

    }
}
