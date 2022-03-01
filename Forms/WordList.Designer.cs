namespace EnglishEducation.Forms
{
    partial class WordList
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
            this.lbWordList = new System.Windows.Forms.ListBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.linkAddExcel = new System.Windows.Forms.LinkLabel();
            this.btnListSelected = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
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
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(864, 372);
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
            this.dataGridView1.Size = new System.Drawing.Size(864, 372);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IsSelected
            // 
            this.IsSelected.DataPropertyName = "IsSelected";
            this.IsSelected.HeaderText = "Select";
            this.IsSelected.Name = "IsSelected";
            // 
            // EnglishNam
            // 
            this.EnglishNam.DataPropertyName = "EnglishWord";
            this.EnglishNam.HeaderText = "English Name";
            this.EnglishNam.Name = "EnglishNam";
            // 
            // TurkishNam
            // 
            this.TurkishNam.DataPropertyName = "TurkishWord";
            this.TurkishNam.HeaderText = "Turkish Name";
            this.TurkishNam.Name = "TurkishNam";
            // 
            // voc
            // 
            this.voc.DataPropertyName = "VocabularyId";
            this.voc.HeaderText = "Vocabulary No";
            this.voc.Name = "voc";
            this.voc.Visible = false;
            // 
            // pnlAddedWord
            // 
            this.pnlAddedWord.Controls.Add(this.lbWordList);
            this.pnlAddedWord.Location = new System.Drawing.Point(887, 3);
            this.pnlAddedWord.Name = "pnlAddedWord";
            this.pnlAddedWord.Size = new System.Drawing.Size(272, 379);
            this.pnlAddedWord.TabIndex = 1;
            // 
            // lbWordList
            // 
            this.lbWordList.FormattingEnabled = true;
            this.lbWordList.Location = new System.Drawing.Point(3, 3);
            this.lbWordList.Name = "lbWordList";
            this.lbWordList.Size = new System.Drawing.Size(255, 355);
            this.lbWordList.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.linkAddExcel);
            this.pnlTop.Controls.Add(this.btnListSelected);
            this.pnlTop.Controls.Add(this.linkLabel1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1171, 85);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_Paint);
            // 
            // linkAddExcel
            // 
            this.linkAddExcel.AutoSize = true;
            this.linkAddExcel.Location = new System.Drawing.Point(106, 19);
            this.linkAddExcel.Name = "linkAddExcel";
            this.linkAddExcel.Size = new System.Drawing.Size(110, 13);
            this.linkAddExcel.TabIndex = 2;
            this.linkAddExcel.TabStop = true;
            this.linkAddExcel.Text = "Word Add From Excel";
            this.linkAddExcel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAddExcel_LinkClicked);
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
            this.linkLabel1.Size = new System.Drawing.Size(58, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "New Word";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // WordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 541);
            this.Controls.Add(this.panel1);
            this.Name = "WordList";
            this.Text = "WordList";
            this.Load += new System.EventHandler(this.WordList_Load);
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
        private System.Windows.Forms.ListBox lbWordList;
        private System.Windows.Forms.Button btnListSelected;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnglishNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurkishNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn voc;
        private System.Windows.Forms.LinkLabel linkAddExcel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}