using EnglishEducation.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnglishEducation.Forms
{
    public partial class WordList : Form
    {
        DatabaseOperations doc;
        DFormOperations fo;
        public List<Vocabulary> vocabularyList;
        public WordList()
        {
           vocabularyList  = new List<Vocabulary>();
            doc = new DatabaseOperations();
            fo = new DFormOperations();
            InitializeComponent();
        }

        private void WordList_Load(object sender, EventArgs e)
        {
            FillGrid();
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WordAdd wordAdd = new WordAdd();
            fo.FunctionFormOpen(wordAdd);
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
            lbWordList.Items.Clear();

            foreach (Vocabulary model in vocabularyList)
            {
                if (model.IsSelected)
                {
                    lbWordList.Items.Add(string.Format("{0} - {1}", model.VocabularyId, model.EnglishWord));
                }
            }
        }
        public void FillGrid() {
            vocabularyList = doc.GetVocabularyList();
            dataGridView1.DataSource = vocabularyList;
        
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void linkAddExcel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            string fileLocation = openFileDialog1.FileName;
            FileOperations fo = new FileOperations();
            fo.ExcelRead(Enums.ExcelDataType.Vocabulary,fileLocation);
            
        }
      

    }
}
