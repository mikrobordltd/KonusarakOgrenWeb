using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KonusarakOgren.Web.Dto.Exams
{
    [AutoMap(typeof(Exam), ReverseMap = true)]
    public class CreateExamDto
    {
        [Required]
        public string Title { get; set; }

        public List<CreateQuestionDto> Questions { get; set; }

    }
}