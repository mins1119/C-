namespace Week7
{
    partial class FormBox
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
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.cboFont = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.grpFont = new System.Windows.Forms.GroupBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.txtBeforeText = new System.Windows.Forms.TextBox();
            this.txtAfterText = new System.Windows.Forms.TextBox();
            this.grpFont.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkBold.Location = new System.Drawing.Point(281, 87);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(50, 16);
            this.chkBold.TabIndex = 0;
            this.chkBold.Text = "굵게";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(39, 21);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 84);
            this.checkedListBox1.TabIndex = 1;
            // 
            // cboFont
            // 
            this.cboFont.FormattingEnabled = true;
            this.cboFont.Location = new System.Drawing.Point(88, 85);
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(151, 20);
            this.cboFont.TabIndex = 2;
            this.cboFont.SelectedIndexChanged += new System.EventHandler(this.cboFont_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(261, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 88);
            this.listBox1.TabIndex = 3;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(217, 183);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(8, 8);
            this.hScrollBar1.TabIndex = 4;
            // 
            // grpFont
            // 
            this.grpFont.Controls.Add(this.txtAfterText);
            this.grpFont.Controls.Add(this.txtBeforeText);
            this.grpFont.Controls.Add(this.chkItalic);
            this.grpFont.Controls.Add(this.lblFont);
            this.grpFont.Controls.Add(this.chkBold);
            this.grpFont.Controls.Add(this.cboFont);
            this.grpFont.Location = new System.Drawing.Point(26, 284);
            this.grpFont.Name = "grpFont";
            this.grpFont.Size = new System.Drawing.Size(492, 170);
            this.grpFont.TabIndex = 5;
            this.grpFont.TabStop = false;
            this.grpFont.Text = "ConboBox, CheckBox, TextBox";
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(35, 89);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(41, 12);
            this.lblFont.TabIndex = 1;
            this.lblFont.Text = "Font : ";
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkItalic.Location = new System.Drawing.Point(372, 87);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(60, 16);
            this.chkItalic.TabIndex = 3;
            this.chkItalic.Text = "이탤릭";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // txtBeforeText
            // 
            this.txtBeforeText.Location = new System.Drawing.Point(27, 40);
            this.txtBeforeText.Name = "txtBeforeText";
            this.txtBeforeText.Size = new System.Drawing.Size(427, 21);
            this.txtBeforeText.TabIndex = 4;
            this.txtBeforeText.Text = "Hello";
            // 
            // txtAfterText
            // 
            this.txtAfterText.Location = new System.Drawing.Point(27, 125);
            this.txtAfterText.Name = "txtAfterText";
            this.txtAfterText.Size = new System.Drawing.Size(427, 21);
            this.txtAfterText.TabIndex = 5;
            // 
            // FormBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 476);
            this.Controls.Add(this.grpFont);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkedListBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBox";
            this.Text = "FormBox";
            this.Load += new System.EventHandler(this.FormBox_Load);
            this.grpFont.ResumeLayout(false);
            this.grpFont.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox cboFont;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.GroupBox grpFont;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.TextBox txtAfterText;
        private System.Windows.Forms.TextBox txtBeforeText;
        private System.Windows.Forms.CheckBox chkItalic;
    }
}