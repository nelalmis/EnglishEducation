namespace EnglishEducation.Forms
{
    partial class LessonOperations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLessonAdd = new System.Windows.Forms.Button();
            this.btnLessonEdit = new System.Windows.Forms.Button();
            this.btnLessonList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLessonAdd
            // 
            this.btnLessonAdd.Location = new System.Drawing.Point(12, 12);
            this.btnLessonAdd.Name = "btnLessonAdd";
            this.btnLessonAdd.Size = new System.Drawing.Size(271, 294);
            this.btnLessonAdd.TabIndex = 0;
            this.btnLessonAdd.Text = "Lesson Add";
            this.btnLessonAdd.UseVisualStyleBackColor = true;
            this.btnLessonAdd.Click += new System.EventHandler(this.btnLessonAdd_Click);
            // 
            // btnLessonEdit
            // 
            this.btnLessonEdit.Location = new System.Drawing.Point(289, 12);
            this.btnLessonEdit.Name = "btnLessonEdit";
            this.btnLessonEdit.Size = new System.Drawing.Size(271, 294);
            this.btnLessonEdit.TabIndex = 0;
            this.btnLessonEdit.Text = "Lesson Edit";
            this.btnLessonEdit.UseVisualStyleBackColor = true;
            // 
            // btnLessonList
            // 
            this.btnLessonList.Location = new System.Drawing.Point(566, 12);
            this.btnLessonList.Name = "btnLessonList";
            this.btnLessonList.Size = new System.Drawing.Size(271, 294);
            this.btnLessonList.TabIndex = 0;
            this.btnLessonList.Text = "LessonList";
            this.btnLessonList.UseVisualStyleBackColor = true;
            // 
            // LessonOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 556);
            this.ControlBox = false;
            this.Controls.Add(this.btnLessonList);
            this.Controls.Add(this.btnLessonEdit);
            this.Controls.Add(this.btnLessonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LessonOperations";
            this.Text = "LessonOperations";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLessonAdd;
        private System.Windows.Forms.Button btnLessonEdit;
        private System.Windows.Forms.Button btnLessonList;

    }
}