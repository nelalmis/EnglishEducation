using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public class Lesson
    {
        #region Tablo alanları
        public int LessonId { get; set; }
        public String LessonName { get; set; }
        public DateTime LessonDate { get; set; }
        public List<int> LessonQuestionId { get; set; }
        #endregion

        #region Tablo dışındaki alanlar
        public string LessonLocation { get; set; }
        public int LessonNumber { get; set; }
        #endregion
    }
}
