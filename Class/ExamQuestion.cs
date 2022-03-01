using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnglishEducation.Class
{
    public class ExamQuestion
    {
        public QuizClass Question { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string E { get; set; }
        public ExamQuestion()
        {
            Question = new QuizClass();
        }
       
    }
}
