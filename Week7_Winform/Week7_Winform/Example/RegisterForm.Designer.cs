namespace Week7_Winform.Example
{
    partial class RegisterForm
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
            this.components = new System.ComponentModel.Container();
            this.panelBack = new System.Windows.Forms.Panel();
            this.btnRegi = new System.Windows.Forms.Button();
            this.RegisterPic = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textPw2 = new System.Windows.Forms.TextBox();
            this.textPw = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.textPhone = new System.Windows.Forms.MaskedTextBox();
            this.fbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterPic)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBack
            // 
            this.panelBack.Controls.Add(this.btnRegi);
            this.panelBack.Controls.Add(this.RegisterPic);
            this.panelBack.Controls.Add(this.panel2);
            this.panelBack.Controls.Add(this.panel1);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBack.Location = new System.Drawing.Point(0, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(538, 322);
            this.panelBack.TabIndex = 0;
            // 
            // btnRegi
            // 
            this.btnRegi.Location = new System.Drawing.Point(376, 251);
            this.btnRegi.Name = "btnRegi";
            this.btnRegi.Size = new System.Drawing.Size(139, 35);
            this.btnRegi.TabIndex = 2;
            this.btnRegi.Text = "가입";
            this.btnRegi.UseVisualStyleBackColor = true;
            this.btnRegi.Click += new System.EventHandler(this.btnRegi_Click);
            // 
            // RegisterPic
            // 
            this.RegisterPic.Location = new System.Drawing.Point(375, 13);
            this.RegisterPic.Name = "RegisterPic";
            this.RegisterPic.Size = new System.Drawing.Size(140, 175);
            this.RegisterPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RegisterPic.TabIndex = 0;
            this.RegisterPic.TabStop = false;
            this.RegisterPic.Click += new System.EventHandler(this.RegisterPic_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textPw2);
            this.panel2.Controls.Add(this.textPw);
            this.panel2.Controls.Add(this.textId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Controls.Add(this.lblId);
            this.panel2.Controls.Add(this.dateBirth);
            this.panel2.Controls.Add(this.textPhone);
            this.panel2.Controls.Add(this.fbtnMale);
            this.panel2.Controls.Add(this.rbtnFemale);
            this.panel2.Controls.Add(this.lblBirth);
            this.panel2.Controls.Add(this.lblPhone);
            this.panel2.Controls.Add(this.lblGender);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.textName);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 290);
            this.panel2.TabIndex = 1;
            // 
            // textPw2
            // 
            this.textPw2.Location = new System.Drawing.Point(115, 253);
            this.textPw2.Name = "textPw2";
            this.textPw2.PasswordChar = '*';
            this.textPw2.Size = new System.Drawing.Size(187, 21);
            this.textPw2.TabIndex = 14;
            this.textPw2.TextChanged += new System.EventHandler(this.textPw2_TextChanged);
            this.textPw2.Enter += new System.EventHandler(this.textPw2_Enter);
            // 
            // textPw
            // 
            this.textPw.Location = new System.Drawing.Point(115, 219);
            this.textPw.Name = "textPw";
            this.textPw.PasswordChar = '*';
            this.textPw.Size = new System.Drawing.Size(187, 21);
            this.textPw.TabIndex = 13;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(115, 184);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(187, 21);
            this.textId.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(22, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Password";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPassword.Location = new System.Drawing.Point(22, 222);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(72, 15);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblId.Location = new System.Drawing.Point(22, 187);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 15);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "ID";
            // 
            // dateBirth
            // 
            this.dateBirth.Location = new System.Drawing.Point(115, 119);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(187, 21);
            this.dateBirth.TabIndex = 8;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(115, 86);
            this.textPhone.Mask = "000-9000-0000";
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(187, 21);
            this.textPhone.TabIndex = 7;
            // 
            // fbtnMale
            // 
            this.fbtnMale.AutoSize = true;
            this.fbtnMale.Location = new System.Drawing.Point(251, 56);
            this.fbtnMale.Name = "fbtnMale";
            this.fbtnMale.Size = new System.Drawing.Size(51, 16);
            this.fbtnMale.TabIndex = 6;
            this.fbtnMale.Text = "Male";
            this.fbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Checked = true;
            this.rbtnFemale.Location = new System.Drawing.Point(115, 56);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(65, 16);
            this.rbtnFemale.TabIndex = 5;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBirth.Location = new System.Drawing.Point(22, 122);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(36, 15);
            this.lblBirth.TabIndex = 4;
            this.lblBirth.Text = "Birth";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPhone.Location = new System.Drawing.Point(22, 92);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(50, 15);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Phone";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGender.Location = new System.Drawing.Point(22, 58);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(54, 15);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.Location = new System.Drawing.Point(22, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(115, 17);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(187, 21);
            this.textName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(375, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 179);
            this.panel1.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(538, 322);
            this.Controls.Add(this.panelBack);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panelBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RegisterPic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.MaskedTextBox textPhone;
        private System.Windows.Forms.RadioButton fbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.DateTimePicker dateBirth;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPw2;
        private System.Windows.Forms.TextBox textPw;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox RegisterPic;
        private System.Windows.Forms.Button btnRegi;
    }
}