namespace EnglishEducation.Forms
{
    partial class QuestionList
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
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IsSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EnglishNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurkishNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAddedWord = new System.Windows.Forms.Panel();
            this.lbQuesitonList = new System.Windows.Forms.ListBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnListSelected = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblExcelLoad = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlAddedWord.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlBottom);
            this.panel1.Controls.Add(this.pnlDataGrid);
            this.panel1.Controls.Add(this.pnlTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 541);
            this.panel1.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnSelect);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 473);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1171, 68);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(870, 3);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(289, 62);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Send Selected";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.Controls.Add(this.panel3);
            this.pnlDataGrid.Controls.Add(this.pnlAddedWord);
            this.pnlDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataGrid.Location = new System.Drawing.Point(0, 85);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Size = new System.Drawing.Size(1171, 456);
            this.pnlDataGrid.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(864, 456);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsSelected,
            this.EnglishNam,
            this.TurkishNam,
            this.voc});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(864, 456);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IsSelected
            // 
            this.IsSelected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IsSelected.DataPropertyName = "IsSelected";
            this.IsSelected.HeaderText = "Select";
            this.IsSelected.Name = "IsSelected";
            // 
            // EnglishNam
            // 
            this.EnglishNam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EnglishNam.DataPropertyName = "EnglishQuestion";
            this.EnglishNam.HeaderText = "English Question";
            this.EnglishNam.Name = "EnglishNam";
            // 
            // TurkishNam
            // 
            this.TurkishNam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TurkishNam.DataPropertyName = "TurkishQuestion";
            this.TurkishNam.HeaderText = "Turkish Question";
            this.TurkishNam.Name = "TurkishNam";
            // 
            // voc
            // 
            this.voc.DataPropertyName = "QuestionId";
            this.voc.HeaderText = "Vocabulary No";
            this.voc.Name = "voc";
            this.voc.Visible = false;
            // 
            // pnlAddedWord
            // 
            this.pnlAddedWord.Controls.Add(this.lbQuesitonList);
            this.pnlAddedWord.Location = new System.Drawing.Point(887, 3);
            this.pnlAddedWord.Name = "pnlAddedWord";
            this.pnlAddedWord.Size = new System.Drawing.Size(272, 379);
            this.pnlAddedWord.TabIndex = 1;
            // 
            // lbQuesitonList
            // 
            this.lbQuesitonList.FormattingEnabled = true;
            this.lbQuesitonList.Location = new System.Drawing.Point(3, 3);
            this.lbQuesitonList.Name = "lbQuesitonList";
            this.lbQuesitonList.Size = new System.Drawing.Size(255, 355);
            this.lbQuesitonList.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblExcelLoad);
            this.pnlTop.Controls.Add(this.btnListSelected);
            this.pnlTop.Controls.Add(this.linkLabel1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1171, 85);
            this.pnlTop.TabIndex = 0;
            // 
            // btnListSelected
            // 
            this.btnListSelected.Location = new System.Drawing.Point(890, 47);
            this.btnListSelected.Name = "btnListSelected";
            this.btnListSelected.Size = new System.Drawing.Size(278, 32);
            this.btnListSelected.TabIndex = 1;
            this.btnListSelected.Text = "List Selected";
            this.btnListSelected.UseVisualStyleBackColor = true;
            this.btnListSelected.Click += new System.EventHandler(this.btnListSelected_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 19);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(74, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "New Question";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblExcelLoad
            // 
            this.lblExcelLoad.AutoSize = true;
            this.lblExcelLoad.Location = new System.Drawing.Point(129, 19);
            this.lblExcelLoad.Name = "lblExcelLoad";
            this.lblExcelLoad.Size = new System.Drawing.Size(116, 13);
            this.lblExcelLoad.TabIndex = 2;
            this.lblExcelLoad.TabStop = true;
            this.lblExcelLoad.Text = "Question Add To Excel";
            this.lblExcelLoad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblExcelLoad_LinkClicked);
            // 
            // QuestionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 541);
            this.Controls.Add(this.panel1);
            this.Name = "QuestionList";
            this.Text = "VocabularyList";
            this.Load += new System.EventHandler(this.QuestionList_Load);
            this.panel1.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlDataGrid.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlAddedWord.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlAddedWord;
        private System.Windows.Forms.ListBox lbQuesitonList;
        private System.Windows.Forms.Button btnListSelected;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnglishNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurkishNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn voc;
        private System.Windows.Forms.LinkLabel lblExcelLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}