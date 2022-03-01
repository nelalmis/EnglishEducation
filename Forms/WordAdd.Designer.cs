namespace EnglishEducation.Forms
{
    partial class WordAdd
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
            this.grpWordInfo = new System.Windows.Forms.GroupBox();
            this.lblTurkishWord = new System.Windows.Forms.Label();
            this.lblEnglishWord = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTurkishWord = new System.Windows.Forms.TextBox();
            this.txtEnglishWord = new System.Windows.Forms.TextBox();
            this.grpWordInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpWordInfo
            // 
            this.grpWordInfo.BackColor = System.Drawing.Color.Bisque;
            this.grpWordInfo.Controls.Add(this.lblTurkishWord);
            this.grpWordInfo.Controls.Add(this.lblEnglishWord);
            this.grpWordInfo.Controls.Add(this.btnSave);
            this.grpWordInfo.Controls.Add(this.label2);
            this.grpWordInfo.Controls.Add(this.label1);
            this.grpWordInfo.Controls.Add(this.txtTurkishWord);
            this.grpWordInfo.Controls.Add(this.txtEnglishWord);
            this.grpWordInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpWordInfo.Location = new System.Drawing.Point(12, 12);
            this.grpWordInfo.Name = "grpWordInfo";
            this.grpWordInfo.Size = new System.Drawing.Size(673, 240);
            this.grpWordInfo.TabIndex = 1;
            this.grpWordInfo.TabStop = false;
            this.grpWordInfo.Text = "Word Info";
            // 
            // lblTurkishWord
            // 
            this.lblTurkishWord.AutoSize = true;
            this.lblTurkishWord.ForeColor = System.Drawing.Color.Red;
            this.lblTurkishWord.Location = new System.Drawing.Point(413, 91);
            this.lblTurkishWord.Name = "lblTurkishWord";
            this.lblTurkishWord.Size = new System.Drawing.Size(0, 24);
            this.lblTurkishWord.TabIndex = 3;
            // 
            // lblEnglishWord
            // 
            this.lblEnglishWord.AutoSize = true;
            this.lblEnglishWord.ForeColor = System.Drawing.Color.Red;
            this.lblEnglishWord.Location = new System.Drawing.Point(413, 46);
            this.lblEnglishWord.Name = "lblEnglishWord";
            this.lblEnglishWord.Size = new System.Drawing.Size(0, 24);
            this.lblEnglishWord.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(229, 133);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(178, 91);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(7, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Turkish Word :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "English Word :";
            // 
            // txtTurkishWord
            // 
            this.txtTurkishWord.Location = new System.Drawing.Point(169, 86);
            this.txtTurkishWord.Name = "txtTurkishWord";
            this.txtTurkishWord.Size = new System.Drawing.Size(238, 29);
            this.txtTurkishWord.TabIndex = 0;
            // 
            // txtEnglishWord
            // 
            this.txtEnglishWord.Location = new System.Drawing.Point(169, 43);
            this.txtEnglishWord.Name = "txtEnglishWord";
            this.txtEnglishWord.Size = new System.Drawing.Size(238, 29);
            this.txtEnglishWord.TabIndex = 0;
            // 
            // WordAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 271);
            this.Controls.Add(this.grpWordInfo);
            this.Name = "WordAdd";
            this.Text = "WordAdd";
            this.grpWordInfo.ResumeLayout(false);
            this.grpWordInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpWordInfo;
        private System.Windows.Forms.Label lblTurkishWord;
        private System.Windows.Forms.Label lblEnglishWord;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTurkishWord;
        private System.Windows.Forms.TextBox txtEnglishWord;

    }
}