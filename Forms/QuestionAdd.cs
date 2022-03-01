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
    public partial class QuestionAdd : Form
    {
        DatabaseOperations doc;
        public QuestionAdd()
        {
            doc = new DatabaseOperations();
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            doc.AddQuestion(txtEnglishQuestion.Text, txtTurkishQuestion.Text);
            this.Close();
        }
    }
}
