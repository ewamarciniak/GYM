//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GYM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExerciseLog
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public string AspNetUserId { get; set; }
        public short Duration { get; set; }
    
        public virtual Activity Activity { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
