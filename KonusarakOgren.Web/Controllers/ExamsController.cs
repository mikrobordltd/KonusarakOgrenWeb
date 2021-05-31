using AutoMapper;
using KonusarakOgren.Web.Data;
using KonusarakOgren.Web.Dto.Exams;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;

namespace KonusarakOgren.Web.Controllers
{
    [Authorize()]
    public class ExamsController : KOBaseController
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CreateExamDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var exam = Mapper.Map<Exam>(dto);

             exam = SqlClient.CreateExam(exam);

            return RedirectToAction("edit", "Exams", new { id = exam.Id });
        }

        [HttpGet]
        public ActionResult Edit(long id)
        {
            var exam = SqlClient.GetExam(id);
            var questions = SqlClient.GetQuestions(id);

            var examUpdateDto = Mapper.Map<UpdateExamDto>(exam);
            examUpdateDto.Questions = Mapper.Map<List<UpdateQuestionDto>>(questions);

            return View(examUpdateDto);
        }

        [HttpPost]
        public ActionResult Edit(UpdateExamDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var exam = Mapper.Map<Exam>(dto);

            SqlClient.UpdateExam(dto.Id, exam);

            return RedirectToAction("Edit", "Exams", new { id = dto.Id });
        }


        public ActionResult List()
        {
            return View(SqlClient.GetAllExams());
        }
    }
}
