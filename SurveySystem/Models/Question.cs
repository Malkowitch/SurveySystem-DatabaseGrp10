using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveySystem.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string QuestionDesc { get; set; }
        public bool AnswerRequired { get; set; }
        public int RatingMaxValue { get; set; }
        public int SurveyInt { get; set; }
        public int InputId { get; set; }
        public ICollection<MultiOption> MultiOptions { get; set; }
    }
}