using EnglishEducation.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnglishEducation.Forms
{
    public partial class MainPageView : Form
    {
        DatabaseOperations doc;
        List<ExamQuestion> ExamQuestionList;
        Enums.TestType TestType;
        public MainPageView()
        {
            ExamQuestionList = new List<ExamQuestion>();
            doc = new DatabaseOperations();
            InitializeComponent();
        }

        private void MainPageView_Load(object sender, EventArgs e)
        {
           

        }


        int i = 0;
        private void btnNext_Click(object sender, EventArgs e)
        {

            if (rdA.Checked)
            {
                AnswerControl(rdA.Text, ExamQuestionList[i].Question.Answer);
            }
            else if (rdB.Checked)
            {
                AnswerControl(rdB.Text, ExamQuestionList[i].Question.Answer);
            }
            else if (rdC.Checked)
            {
                AnswerControl(rdC.Text, ExamQuestionList[i].Question.Answer);
            }
            else if (rdD.Checked)
            {
                AnswerControl(rdD.Text, ExamQuestionList[i].Question.Answer);
            }
            else if (rdE.Checked)
            {
                AnswerControl(rdE.Text, ExamQuestionList[i].Question.Answer);
            }
            if (i + 1 < ExamQuestionList.Count())
            {
                i++;
                rdA.Text = ExamQuestionList[i].A;
                rdB.Text = ExamQuestionList[i].B;
                rdC.Text = ExamQuestionList[i].C;
                rdD.Text = ExamQuestionList[i].D;
                rdE.Text = ExamQuestionList[i].E;
                lblQuestion.Text = ExamQuestionList[i].Question.Question;
            }

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (i - 1 >= 0)
            {
                i--;
                rdA.Text = ExamQuestionList[i].A;
                rdB.Text = ExamQuestionList[i].B;
                rdC.Text = ExamQuestionList[i].C;
                rdD.Text = ExamQuestionList[i].D;
                rdE.Text = ExamQuestionList[i].E;
                lblQuestion.Text = ExamQuestionList[i].Question.Question;
            }

        }
        public bool AnswerControl(string answer, string currentAnswer)
        {
            bool result = false;
            if (answer == currentAnswer)
            {
                MessageBox.Show("Doğru cevap tebrikler", "Sonuç");
                result= true;
            }else
            MessageBox.Show("Yanlış cevap. Doğru cevap "+ currentAnswer +"");
            CheckClear();
            return result;
        }


        private void rdQuestionTest_CheckedChanged(object sender, EventArgs e)
        {
            QuestionAlgorithm questionAlgorithm = new QuestionAlgorithm();
            ExamQuestionList = questionAlgorithm.DoQuestionEnglishTurkishByQuestion(Enums.QuestionType.EnglishTurkish);
            rdA.Text = ExamQuestionList[0].A;
            rdB.Text = ExamQuestionList[0].B;
            rdC.Text = ExamQuestionList[0].C;
            rdD.Text = ExamQuestionList[0].D;
            rdE.Text = ExamQuestionList[0].E;
            lblQuestion.Text = ExamQuestionList[0].Question.Question;
            TestType = Enums.TestType.Question;

        }

        private void rdVocabulary_CheckedChanged(object sender, EventArgs e)
        {
            QuestionAlgorithm questionAlgorithm = new QuestionAlgorithm();
            ExamQuestionList = questionAlgorithm.DoQuestionEnglishTurkishByVocabulary(Enums.QuestionType.EnglishTurkish);
            rdA.Text = ExamQuestionList[0].A;
            rdB.Text = ExamQuestionList[0].B;
            rdC.Text = ExamQuestionList[0].C;
            rdD.Text = ExamQuestionList[0].D;
            rdE.Text = ExamQuestionList[0].E;
            lblQuestion.Text = ExamQuestionList[0].Question.Question;
            TestType = Enums.TestType.Vocabulary;
        }

        private void rdQuestionAnwer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdVocabularyTurEng_Click(object sender, EventArgs e)
        {
            QuestionAlgorithm questionAlgorithm = new QuestionAlgorithm();
            ExamQuestionList = questionAlgorithm.DoQuestionEnglishTurkishByVocabulary(Enums.QuestionType.TurkishEnglish);
            rdA.Text = ExamQuestionList[0].A;
            rdB.Text = ExamQuestionList[0].B;
            rdC.Text = ExamQuestionList[0].C;
            rdD.Text = ExamQuestionList[0].D;
            rdE.Text = ExamQuestionList[0].E;
            lblQuestion.Text = ExamQuestionList[0].Question.Question;
            TestType = Enums.TestType.Vocabulary;
        }

        private void rdQuestionTurEng_CheckedChanged(object sender, EventArgs e)
        {
            QuestionAlgorithm questionAlgorithm = new QuestionAlgorithm();
            ExamQuestionList = questionAlgorithm.DoQuestionEnglishTurkishByQuestion(Enums.QuestionType.TurkishEnglish);
            rdA.Text = ExamQuestionList[0].A;
            rdB.Text = ExamQuestionList[0].B;
            rdC.Text = ExamQuestionList[0].C;
            rdD.Text = ExamQuestionList[0].D;
            rdE.Text = ExamQuestionList[0].E;
            lblQuestion.Text = ExamQuestionList[0].Question.Question;
            TestType = Enums.TestType.Question;
        }
        private void CheckClear()
        {
            rdA.Checked = false;
            rdB.Checked = false;
            rdC.Checked = false;
            rdD.Checked = false;
            rdE.Checked = false;
        }
    }
}
