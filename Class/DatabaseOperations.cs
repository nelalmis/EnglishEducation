using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnglishEducation.Class
{
    public  class DatabaseOperations
    {
        EnglishEducationEntities db;
        public DatabaseOperations()
        {
            db = new EnglishEducationEntities();
        }
        public List<Parameter> GetListParameterByParamType(string paramType)
        {
            return db.Parameter.Where(u => u.ParamType == paramType).ToList();
        }
        public void AddVocabulary(string engWord, string turkWord)
        {
            if (GetVocabulary(engWord) != null || engWord==null || turkWord==null)
                return;
            Vocabulary voca = new Vocabulary
            {
                EnglishWord = engWord,
                TurkishWord = turkWord
            };
            db.Vocabulary.Add(voca);
            db.SaveChanges();

        }
        public List<Vocabulary> GetVocabularyList() {
           return db.Vocabulary.ToList();
        
        }
        public List<Question> GetQuestionList()
        {
            return db.Question.ToList();

        }
        public void AddQuestion(string engQues, string turkQues)
        {
            if (engQues == null || turkQues == null)
                return;
            Question voca = new Question
            {
                EnglishQuestion = engQues,
                TurkishQuestion = turkQues
            };
            db.Question.Add(voca);
            db.SaveChanges();

        }
        public void AddLesson(int lessonNumber,string lessonSubject, DateTime lessonDate, int levelNumber, int stepNumber, int unitNumber, string bookUrl, string audioUrl, List<Question> questionList, List<Vocabulary> vocabularyList)
        {
            Lesson lesson = new Lesson()
            {
                LessonAudioLocation = audioUrl,
                LessonBookLocation = bookUrl,
                LessonDate = lessonDate,
                LevelNumber = levelNumber,
                StepNumber = stepNumber,
                UnitNumber = unitNumber,
                LessonNumber=lessonNumber,
                LessonSubject = lessonSubject

            };
            db.Lesson.Add(lesson);
            db.SaveChanges();
            int LessonId = db.Lesson.ToList().LastOrDefault().LessonId;
            LessonQuestion question;
            foreach (var item in questionList)
            {
                question = new LessonQuestion
                {
                    LessonId = LessonId,
                    QuestionId = item.QuestionId
                };
                db.LessonQuestion.Add(question);
            }
            LessonVocabulary vocabulary;
            foreach (var item in vocabularyList)
            {
                vocabulary = new LessonVocabulary
                {
                    LessonId = LessonId,
                    VocabularyId = item.VocabularyId
                };
                db.LessonVocabulary.Add(vocabulary);
            }
            db.SaveChanges();
        }
        public Vocabulary GetVocabulary(string englishWord)
        {
            return db.Vocabulary.Where(u => u.EnglishWord == englishWord).FirstOrDefault();

        }
        public void TryEntityModel()
        {
           
        }
        

    }
}
