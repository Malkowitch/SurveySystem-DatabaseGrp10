using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SurveySystem.Models
{
    public class MultiOption
    {
        [Key]
        public int OptionId { get; set; }
        public string OptionText { get; set; }
        public int QuestionId { get; set; }
    }
}