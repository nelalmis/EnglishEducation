//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnglishEducation
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lesson
    {
        public int LessonId { get; set; }
        public Nullable<int> LessonNumber { get; set; }
        public string LessonSubject { get; set; }
        public Nullable<System.DateTime> LessonDate { get; set; }
        public Nullable<int> LevelNumber { get; set; }
        public Nullable<int> StepNumber { get; set; }
        public Nullable<int> UnitNumber { get; set; }
        public string LessonBookLocation { get; set; }
        public string LessonAudioLocation { get; set; }
    }
}
