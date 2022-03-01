using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnglishEducation.Class
{
    public  class QuestionAlgorithm
    {
        
        public QuestionAlgorithm() {
            
        
        }
        public List<ExamQuestion> DoQuestionEnglishTurkishByQuestion(Enums.QuestionType questionType)
        {
            Random random = new Random();
            List<ExamQuestion> ExamQuestionList = new List<ExamQuestion>();
            DatabaseOperations doc = new DatabaseOperations();
            List<Question> QuestionList = doc.GetQuestionList();
            List<Question> ExamQuestion = new List<Question>();
            ExamQuestion examQuestion;
            for (int i = 0; i < QuestionList.Count(); i++)
            {
                var questionIndex = random.Next(0, QuestionList.Count() - 1);
                var questionQındex=random.Next(0,4);
                var question = QuestionList[questionIndex];
                var randomList = DoRandomNumberN(QuestionList.Count(), 4, questionIndex);
                ExamQuestion.Clear();
                foreach (var item in randomList)
                {
                    ExamQuestion.Add(QuestionList[item]);
                }
                //ExamQuestion = ListeKaristir(ExamQuestion);
                ExamQuestion.Add(question);
                var tmp = ExamQuestion[questionQındex];
                ExamQuestion[questionQındex] =question;
                ExamQuestion[4] = tmp;
                if (randomList != null)
                {
                    if (questionType == Enums.QuestionType.EnglishTurkish)
                    {
                        examQuestion = new ExamQuestion();
                        examQuestion.Question.Question = question.EnglishQuestion;
                        examQuestion.Question.Answer = question.TurkishQuestion;
                        examQuestion.A = ExamQuestion[0].TurkishQuestion;
                        examQuestion.B = ExamQuestion[1].TurkishQuestion;
                        examQuestion.C = ExamQuestion[2].TurkishQuestion;
                        examQuestion.D = ExamQuestion[3].TurkishQuestion;
                        examQuestion.E = ExamQuestion[4].TurkishQuestion;
                    }
                    else 
                    {
                        examQuestion = new ExamQuestion();
                        examQuestion.Question.Question = question.TurkishQuestion;
                        examQuestion.Question.Answer = question.EnglishQuestion;
                        examQuestion.A = ExamQuestion[0].EnglishQuestion;
                        examQuestion.B = ExamQuestion[1].EnglishQuestion;
                        examQuestion.C = ExamQuestion[2].EnglishQuestion;
                        examQuestion.D = ExamQuestion[3].EnglishQuestion;
                        examQuestion.E = ExamQuestion[4].EnglishQuestion;
                    
                    }
                    ExamQuestionList.Add(examQuestion);
                }
            }
            
            return ExamQuestionList;
        }



        public List<int> DoRandomNumberN(int listCount, int n, int notIndex)
        {
            if (listCount <= n)
            {
                return null;
            }
            int i = 0;
            Random random = new Random();
            List<int> list = new List<int>();
            while (i < n)
            {
                int randomValue = random.Next(0, listCount - 1);
                if (!list.Contains(randomValue) && randomValue != notIndex)
                {
                    list.Add(randomValue);
                    i++;
                }
            }
            return list;

        }
        public List<int> DoRandomNumberN(int listCount, int n, List<int> listNotIndex)
        {
            if (listCount <= n)
            {
                return null;
            }
            int i = 0;
            Random random = new Random();
            List<int> list = new List<int>();
            while (i < n)
            {
                int randomValue = random.Next(0, listCount - 1);
                if (!list.Contains(randomValue) && !listNotIndex.Contains(randomValue))
                {
                    list.Add(randomValue);
                    i++;
                }
            }
            return list;

        }
        public List<Question> ListeKaristir(List<Question> Liste)
        {
            List<int> RandomList = new List<int>(); 
            for (int i = 0; i < 2; i++)
            {
                RandomList = DoRandomNumberN(5, 2, RandomList);
                var tmp = Liste[RandomList[0]];
                Liste[RandomList[0]] = Liste[RandomList[1]];
                Liste[RandomList[1]] = tmp;
            }
            return Liste;
            //Random r = new Random();
            //List<Question> tmpList = Liste.GetRange(0, Liste.Count);
            //List<Question> arrReturn = new List<Question>();
            //while (tmpList.Count > 0)
            //{
            //    int rastgele = r.Next(0, tmpList.Count-1);
            //    arrReturn.Add(tmpList[rastgele]);
            //    tmpList.RemoveAt(rastgele);
            //}
            //return arrReturn;
        }

        public List<ExamQuestion> DoQuestionEnglishTurkishByVocabulary(Enums.QuestionType questionType)
        {
            Random random = new Random();
            List<ExamQuestion> ExamQuestionList = new List<ExamQuestion>();
            DatabaseOperations doc = new DatabaseOperations();
            List<Vocabulary> VocabularyList = doc.GetVocabularyList();
            List<Vocabulary> ExamQuestion = new List<Vocabulary>();
            ExamQuestion examQuestion;
            for (int i = 0; i < VocabularyList.Count(); i++)
            {
                var questionIndex = random.Next(0, VocabularyList.Count() - 1);
                var questionQındex = random.Next(0, 4);
                var question = VocabularyList[questionIndex];
                var randomList = DoRandomNumberN(VocabularyList.Count(), 4, questionIndex);
                ExamQuestion.Clear();
                foreach (var item in randomList)
                {
                    ExamQuestion.Add(VocabularyList[item]);
                }
                //ExamQuestion = ListeKaristir(ExamQuestion);
                ExamQuestion.Add(question);
                var tmp = ExamQuestion[questionQındex];
                ExamQuestion[questionQındex] = question;
                ExamQuestion[4] = tmp;
                if (randomList != null)
                {
                    if (questionType == Enums.QuestionType.EnglishTurkish)
                    {
                        examQuestion = new ExamQuestion();
                        examQuestion.Question.Question = question.EnglishWord;
                        examQuestion.Question.Answer = question.TurkishWord;
                        examQuestion.A = ExamQuestion[0].TurkishWord;
                        examQuestion.B = ExamQuestion[1].TurkishWord;
                        examQuestion.C = ExamQuestion[2].TurkishWord;
                        examQuestion.D = ExamQuestion[3].TurkishWord;
                        examQuestion.E = ExamQuestion[4].TurkishWord;
                    }
                    else {
                        examQuestion = new ExamQuestion();
                        examQuestion.Question.Question = question.TurkishWord;
                        examQuestion.Question.Answer = question.EnglishWord;
                        examQuestion.A = ExamQuestion[0].EnglishWord;
                        examQuestion.B = ExamQuestion[1].EnglishWord;
                        examQuestion.C = ExamQuestion[2].EnglishWord;
                        examQuestion.D = ExamQuestion[3].EnglishWord;
                        examQuestion.E = ExamQuestion[4].EnglishWord;
                    
                    }
                    ExamQuestionList.Add(examQuestion);
                }
            }

            return ExamQuestionList;
        }


    }
}
