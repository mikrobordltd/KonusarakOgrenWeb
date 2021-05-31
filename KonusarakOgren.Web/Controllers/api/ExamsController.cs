using KonusarakOgren.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KonusarakOgren.Web.Controllers.api
{
    [RoutePrefix("api/exams")]
    public class ExamsController : KOApiBaseController
    {
        [HttpGet]
        [Route("")]
        public List<Exam> GetAll()
        {
            return SqlClient.GetAllExams();
        }

        [HttpGet]
        [Route("{id}")]
        public Exam Get(long id)
        {
            var exam = SqlClient.GetExam(id);
            exam.Questions = SqlClient.GetQuestions(id);
            return exam;
        }

    }
}
