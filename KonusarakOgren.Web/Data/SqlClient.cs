using AutoMapper;
using KonusarakOgren.Web.Dto.Exams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KonusarakOgren.Web.Data
{
    public class SqlClient : SqlClientBase
    {

        public User GetUser(string username)
        {
            return Context.Users.FirstOrDefault(x => x.Username == username);
        }


        public List<Exam> GetAllExams()
        {
            return Context.Exams.ToList();
        }

        public Exam GetExam(long id)
        {
            return Context.Exams.FirstOrDefault(x => x.Id == id);
        }

        public Exam CreateExam(Exam exam)
        {
            exam = Context.Exams.Add(exam);
            Context.SaveChanges();

            return exam;
        }

        public Exam UpdateExam(long id, Exam updateExam)
        {
            var exam = Context.Exams.FirstOrDefault(x => x.Id == updateExam.Id);
            exam.Title = updateExam.Title;
            Context.SaveChanges();

            foreach (var q in updateExam.Questions)
            {
                var question = Context.Questions.FirstOrDefault(x => x.Id == q.Id && x.ExamId == exam.Id);
                question.OptionA = q.OptionA;
                question.OptionB = q.OptionB;
                question.OptionC = q.OptionC;
                question.OptionD = q.OptionD;
                question.OptionE = q.OptionE;
                question.Text = q.Text;
                question.TrueOption = q.TrueOption;
            }
            Context.SaveChanges();
            return exam;
        }


        public List<Question> GetQuestions(long examId)
        {
            return Context.Questions.Where(x => x.ExamId == examId).ToList();
        }

    }
}