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
    public partial class WordAdd : Form
    {
        DatabaseOperations doc;
        public WordAdd()
        {
            doc = new DatabaseOperations();
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            doc.AddVocabulary(txtEnglishWord.Text, txtTurkishWord.Text);
            this.Close();
        }
    }
}
