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
    
    public partial class AnswerText
    {
        public Nullable<int> AnswerId { get; set; }
        public string TextInput { get; set; }
        public int AnswerTextId { get; set; }
    
        public virtual Answer Answer { get; set; }
    }
}
