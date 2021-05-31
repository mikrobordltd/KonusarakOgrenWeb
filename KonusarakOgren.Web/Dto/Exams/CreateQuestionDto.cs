using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KonusarakOgren.Web.Dto.Exams
{
    [AutoMap(typeof(Question), ReverseMap = true)]
    public class CreateQuestionDto
    {
        [Required]
        public string Text { get; set; }
        [Required]
        public string OptionA { get; set; }
        [Required]
        public string OptionB { get; set; }
        [Required]
        public string OptionC { get; set; }
        [Required]
        public string OptionD { get; set; }
        [Required]
        public string OptionE { get; set; }
        [Required]
        public long TrueOption { get; set; }
    }
}