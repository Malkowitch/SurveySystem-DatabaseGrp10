using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SurveySystem.Models
{
    public class InputType
    {
        [Key]
        public int InputId { get; set; }
        public string Type { get; set; }
    }
}