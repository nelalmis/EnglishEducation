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
    public partial class QuestionList : Form
    {
        DatabaseOperations doc;
        DFormOperations fo;
        public List<Question> questionList;
        public QuestionList()
        {
          
            doc = new DatabaseOperations();
            fo = new DFormOperations();
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuestionAdd questionAdd = new QuestionAdd();
            fo.FunctionFormOpen(questionAdd);
            FillGrid();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.Close();
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void btnListSelected_Click(object sender, EventArgs e)
        {
            lbQuesitonList.Items.Clear();

            foreach (Question model in questionList)
            {
                if (model.IsSelected)
                {
                    lbQuesitonList.Items.Add(string.Format("{0} - {1}", model.QuestionId, model.EnglishQuestion));
                }
            }
        }
        public void FillGrid()
        {
            questionList = doc.GetQuestionList();
            dataGridView1.DataSource = questionList;
        }

        private void QuestionList_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void lblExcelLoad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            string fileLocation = openFileDialog1.FileName;
            FileOperations fo = new FileOperations();
            fo.ExcelRead(Enums.ExcelDataType.Question, fileLocation);
        }
    }
}
