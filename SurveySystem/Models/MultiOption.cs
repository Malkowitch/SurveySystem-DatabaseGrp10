//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SurveySystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MultiOption
    {
        public int OptionId { get; set; }
        public string OptionText { get; set; }
        public Nullable<int> QuestionId { get; set; }
    
        public virtual Question Question { get; set; }
    }
}
