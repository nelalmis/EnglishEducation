using EnglishEducation.Class;
using EnglishEducation.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnglishEducation
{
    public partial class MainPage : Form
    {
        DFormOperations formOperations; 
        public MainPage()
        {
            formOperations = new DFormOperations();
            InitializeComponent();
        }

       
        private void btnMainPage_Click(object sender, EventArgs e)
        {
            MainPageView mainPageView;
            
            mainPageView = new MainPageView();
            FunctionFormOpen(mainPageView);
           
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void FunctionFormOpen(System.Windows.Forms.Form form)
        {
           
            splitContainer1.Panel2.Controls.Clear();
            form.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(form);
            form.Show();
          
        }

        private void btnLesson_Click(object sender, EventArgs e)
        {
            LessonOperations lessonOperations = new LessonOperations();
            FunctionFormOpen(lessonOperations);
        }
    }
}
