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
    public partial class LessonOperations : Form
    {
        DFormOperations formOperations;
        public LessonOperations()
        {
            formOperations = new DFormOperations();
            InitializeComponent();
        }

        private void btnLessonAdd_Click(object sender, EventArgs e)
        {
            LessonAdd lessonAdd=new LessonAdd();
            formOperations.FunctionFormOpen(lessonAdd);
        }
    }
}
