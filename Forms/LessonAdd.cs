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
    public partial class LessonAdd : Form
    {
        DatabaseOperations doc;
        DFormOperations fo;
        List<Vocabulary> LessonVocabularyList;
        public LessonAdd()
        {
            fo = new DFormOperations();
            doc = new DatabaseOperations();
            InitializeComponent();
        }
        public LessonAdd(List<Vocabulary> vocabularyList):this()
        {
            LessonVocabularyList = vocabularyList;
            InitializeComponent();
        }
        private void LessonAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'englishEducationDataSet.Vocabulary' table. You can move, or remove it, as needed.
            
            cmbLevel.DataSource = doc.GetListParameterByParamType("Level");
            cmbLevel.DisplayMember = "ParamDescription";
            cmbLevel.ValueMember = "ParamValue";
            cmbStep.DataSource = doc.GetListParameterByParamType("Step");
            cmbStep.DisplayMember = "ParamDescription";
            cmbStep.ValueMember = "ParamValue";
            cmbUnit.DataSource = doc.GetListParameterByParamType("Unit");
            cmbUnit.DisplayMember = "ParamDescription";
            cmbUnit.ValueMember = "ParamValue";
           
            
        }

        private void btnWordAdd_Click(object sender, EventArgs e)
        {
            WordList wordList = new WordList();
            fo.FunctionFormOpen(wordList);
            dtVocabulary.DataSource = wordList.vocabularyList.Where(u => u.IsSelected == true).ToList();
        }
        public void FillDataGrid() 
        {
            dtVocabulary.DataSource = LessonVocabularyList;
            
        }

        private void btnQuestionAdd_Click(object sender, EventArgs e)
        {
            QuestionList questionList = new QuestionList();
            fo.FunctionFormOpen(questionList);
            dtQuestion.DataSource = questionList.questionList.Where(u => u.IsSelected == true).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var af = dtQuestion.DataSource;
            doc.AddLesson(Convert.ToInt32(txtLessonNumber.Text),txtSubject.Text, dateTimePicker1.Value, (int)cmbLevel.SelectedValue, (int)cmbStep.SelectedValue,(int) cmbUnit.SelectedValue, "", "", (List<Question>)dtQuestion.DataSource,(List<Vocabulary>)dtVocabulary.DataSource);

            this.Close();

        }
    }
}
