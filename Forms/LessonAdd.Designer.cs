namespace EnglishEducation.Forms
{
    partial class LessonAdd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpVocabulary = new System.Windows.Forms.GroupBox();
            this.dtVocabulary = new System.Windows.Forms.DataGridView();
            this.btnWordAdd = new System.Windows.Forms.Button();
            this.grpLessonInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.txtLessonNumber = new System.Windows.Forms.MaskedTextBox();
            this.cmbStep = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.IsSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EnglishNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurkishNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteWord = new System.Windows.Forms.Button();
            this.grpQuestion = new System.Windows.Forms.GroupBox();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.dtQuestion = new System.Windows.Forms.DataGridView();
            this.btnQuestionAdd = new System.Windows.Forms.Button();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpMaterial = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.grpVocabulary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtVocabulary)).BeginInit();
            this.grpLessonInfo.SuspendLayout();
            this.grpQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpMaterial);
            this.panel1.Controls.Add(this.grpQuestion);
            this.panel1.Controls.Add(this.grpVocabulary);
            this.panel1.Controls.Add(this.grpLessonInfo);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1294, 598);
            this.panel1.TabIndex = 0;
            // 
            // grpVocabulary
            // 
            this.grpVocabulary.Controls.Add(this.btnDeleteWord);
            this.grpVocabulary.Controls.Add(this.dtVocabulary);
            this.grpVocabulary.Controls.Add(this.btnWordAdd);
            this.grpVocabulary.Location = new System.Drawing.Point(705, 13);
            this.grpVocabulary.Name = "grpVocabulary";
            this.grpVocabulary.Size = new System.Drawing.Size(538, 227);
            this.grpVocabulary.TabIndex = 6;
            this.grpVocabulary.TabStop = false;
            this.grpVocabulary.Text = "Vocabulary";
            // 
            // dtVocabulary
            // 
            this.dtVocabulary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtVocabulary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsSelected,
            this.EnglishNam,
            this.TurkishNam,
            this.voc});
            this.dtVocabulary.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtVocabulary.Location = new System.Drawing.Point(3, 16);
            this.dtVocabulary.Name = "dtVocabulary";
            this.dtVocabulary.ReadOnly = true;
            this.dtVocabulary.Size = new System.Drawing.Size(532, 176);
            this.dtVocabulary.TabIndex = 1;
            // 
            // btnWordAdd
            // 
            this.btnWordAdd.Location = new System.Drawing.Point(457, 198);
            this.btnWordAdd.Name = "btnWordAdd";
            this.btnWordAdd.Size = new System.Drawing.Size(75, 23);
            this.btnWordAdd.TabIndex = 0;
            this.btnWordAdd.Text = "Word Add";
            this.btnWordAdd.UseVisualStyleBackColor = true;
            this.btnWordAdd.Click += new System.EventHandler(this.btnWordAdd_Click);
            // 
            // grpLessonInfo
            // 
            this.grpLessonInfo.Controls.Add(this.txtSubject);
            this.grpLessonInfo.Controls.Add(this.label6);
            this.grpLessonInfo.Controls.Add(this.label1);
            this.grpLessonInfo.Controls.Add(this.label2);
            this.grpLessonInfo.Controls.Add(this.label3);
            this.grpLessonInfo.Controls.Add(this.dateTimePicker1);
            this.grpLessonInfo.Controls.Add(this.label4);
            this.grpLessonInfo.Controls.Add(this.cmbLevel);
            this.grpLessonInfo.Controls.Add(this.label5);
            this.grpLessonInfo.Controls.Add(this.cmbUnit);
            this.grpLessonInfo.Controls.Add(this.txtLessonNumber);
            this.grpLessonInfo.Controls.Add(this.cmbStep);
            this.grpLessonInfo.Location = new System.Drawing.Point(15, 12);
            this.grpLessonInfo.Name = "grpLessonInfo";
            this.grpLessonInfo.Size = new System.Drawing.Size(683, 228);
            this.grpLessonInfo.TabIndex = 5;
            this.grpLessonInfo.TabStop = false;
            this.grpLessonInfo.Text = "Lesson Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lesson Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Step";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(186, 197);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(447, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Unit";
            // 
            // cmbLevel
            // 
            this.cmbLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Location = new System.Drawing.Point(186, 92);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(447, 21);
            this.cmbLevel.TabIndex = 2;
            this.cmbLevel.Text = "Select";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(20, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lesson Date";
            // 
            // cmbUnit
            // 
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(186, 159);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(447, 21);
            this.cmbUnit.TabIndex = 2;
            this.cmbUnit.Text = "Select";
            // 
            // txtLessonNumber
            // 
            this.txtLessonNumber.Location = new System.Drawing.Point(186, 35);
            this.txtLessonNumber.Name = "txtLessonNumber";
            this.txtLessonNumber.Size = new System.Drawing.Size(447, 20);
            this.txtLessonNumber.TabIndex = 1;
            // 
            // cmbStep
            // 
            this.cmbStep.FormattingEnabled = true;
            this.cmbStep.Location = new System.Drawing.Point(186, 127);
            this.cmbStep.Name = "cmbStep";
            this.cmbStep.Size = new System.Drawing.Size(447, 21);
            this.cmbStep.TabIndex = 2;
            this.cmbStep.Text = "Select";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(884, 500);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 86);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1065, 500);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 86);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // IsSelected
            // 
            this.IsSelected.DataPropertyName = "IsSelected";
            this.IsSelected.HeaderText = "Select";
            this.IsSelected.Name = "IsSelected";
            this.IsSelected.ReadOnly = true;
            this.IsSelected.Visible = false;
            // 
            // EnglishNam
            // 
            this.EnglishNam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EnglishNam.DataPropertyName = "EnglishWord";
            this.EnglishNam.HeaderText = "English Name";
            this.EnglishNam.Name = "EnglishNam";
            this.EnglishNam.ReadOnly = true;
            // 
            // TurkishNam
            // 
            this.TurkishNam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TurkishNam.DataPropertyName = "TurkishWord";
            this.TurkishNam.HeaderText = "Turkish Name";
            this.TurkishNam.Name = "TurkishNam";
            this.TurkishNam.ReadOnly = true;
            // 
            // voc
            // 
            this.voc.DataPropertyName = "VocabularyId";
            this.voc.HeaderText = "Vocabulary No";
            this.voc.Name = "voc";
            this.voc.ReadOnly = true;
            this.voc.Visible = false;
            // 
            // btnDeleteWord
            // 
            this.btnDeleteWord.Location = new System.Drawing.Point(7, 199);
            this.btnDeleteWord.Name = "btnDeleteWord";
            this.btnDeleteWord.Size = new System.Drawing.Size(121, 23);
            this.btnDeleteWord.TabIndex = 2;
            this.btnDeleteWord.Text = "Delete Selected Word";
            this.btnDeleteWord.UseVisualStyleBackColor = true;
            // 
            // grpQuestion
            // 
            this.grpQuestion.Controls.Add(this.btnDeleteQuestion);
            this.grpQuestion.Controls.Add(this.dtQuestion);
            this.grpQuestion.Controls.Add(this.btnQuestionAdd);
            this.grpQuestion.Location = new System.Drawing.Point(15, 262);
            this.grpQuestion.Name = "grpQuestion";
            this.grpQuestion.Size = new System.Drawing.Size(683, 227);
            this.grpQuestion.TabIndex = 6;
            this.grpQuestion.TabStop = false;
            this.grpQuestion.Text = "Question";
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.Location = new System.Drawing.Point(7, 199);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(121, 23);
            this.btnDeleteQuestion.TabIndex = 2;
            this.btnDeleteQuestion.Text = "Delete Selected Question";
            this.btnDeleteQuestion.UseVisualStyleBackColor = true;
            // 
            // dtQuestion
            // 
            this.dtQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtQuestion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dtQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtQuestion.Location = new System.Drawing.Point(3, 16);
            this.dtQuestion.Name = "dtQuestion";
            this.dtQuestion.ReadOnly = true;
            this.dtQuestion.Size = new System.Drawing.Size(677, 176);
            this.dtQuestion.TabIndex = 1;
            // 
            // btnQuestionAdd
            // 
            this.btnQuestionAdd.Location = new System.Drawing.Point(602, 198);
            this.btnQuestionAdd.Name = "btnQuestionAdd";
            this.btnQuestionAdd.Size = new System.Drawing.Size(75, 23);
            this.btnQuestionAdd.TabIndex = 0;
            this.btnQuestionAdd.Text = "QuestionAdd";
            this.btnQuestionAdd.UseVisualStyleBackColor = true;
            this.btnQuestionAdd.Click += new System.EventHandler(this.btnQuestionAdd_Click);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsSelected";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Select";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EnglishQuestion";
            this.dataGridViewTextBoxColumn1.HeaderText = "English Question";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TurkishQuestion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Turkish Question";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "QuestionId";
            this.dataGridViewTextBoxColumn3.HeaderText = "Question  No";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // grpMaterial
            // 
            this.grpMaterial.Location = new System.Drawing.Point(712, 278);
            this.grpMaterial.Name = "grpMaterial";
            this.grpMaterial.Size = new System.Drawing.Size(528, 188);
            this.grpMaterial.TabIndex = 7;
            this.grpMaterial.TabStop = false;
            this.grpMaterial.Text = "Lesson Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(20, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Lesson Subject";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(186, 66);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(447, 20);
            this.txtSubject.TabIndex = 5;
            // 
            // LessonAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 598);
            this.Controls.Add(this.panel1);
            this.Name = "LessonAdd";
            this.Text = "LessonAdd";
            this.Load += new System.EventHandler(this.LessonAdd_Load);
            this.panel1.ResumeLayout(false);
            this.grpVocabulary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtVocabulary)).EndInit();
            this.grpLessonInfo.ResumeLayout(false);
            this.grpLessonInfo.PerformLayout();
            this.grpQuestion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpVocabulary;
        private System.Windows.Forms.GroupBox grpLessonInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.MaskedTextBox txtLessonNumber;
        private System.Windows.Forms.ComboBox cmbStep;
        private System.Windows.Forms.Button btnWordAdd;
        public System.Windows.Forms.DataGridView dtVocabulary;
        private System.Windows.Forms.GroupBox grpQuestion;
        private System.Windows.Forms.Button btnDeleteQuestion;
        public System.Windows.Forms.DataGridView dtQuestion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnQuestionAdd;
        private System.Windows.Forms.Button btnDeleteWord;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnglishNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurkishNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn voc;
        private System.Windows.Forms.GroupBox grpMaterial;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label6;
    }
}