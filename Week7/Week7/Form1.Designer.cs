namespace Week7
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnFunc = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelFuncMenu = new System.Windows.Forms.Panel();
            this.btnBox = new System.Windows.Forms.Button();
            this.btnBar = new System.Windows.Forms.Button();
            this.btnEtc = new System.Windows.Forms.Button();
            this.panelEtcMenu = new System.Windows.Forms.Panel();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnEtcEtc = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.panelWriteLog = new System.Windows.Forms.Panel();
            this.panelChild = new System.Windows.Forms.Panel();
            this.textLog = new System.Windows.Forms.TextBox();
            this.panelSideMenu.SuspendLayout();
            this.panelFuncMenu.SuspendLayout();
            this.panelEtcMenu.SuspendLayout();
            this.panelWriteLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.panelSideMenu.Controls.Add(this.btnCopy);
            this.panelSideMenu.Controls.Add(this.panelEtcMenu);
            this.panelSideMenu.Controls.Add(this.btnEtc);
            this.panelSideMenu.Controls.Add(this.panelFuncMenu);
            this.panelSideMenu.Controls.Add(this.btnFunc);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 476);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnFunc
            // 
            this.btnFunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunc.Font = new System.Drawing.Font("카페24 당당해", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFunc.ForeColor = System.Drawing.Color.Black;
            this.btnFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFunc.Location = new System.Drawing.Point(0, 100);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnFunc.Size = new System.Drawing.Size(200, 45);
            this.btnFunc.TabIndex = 0;
            this.btnFunc.Text = "Function";
            this.btnFunc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFunc.UseVisualStyleBackColor = true;
            this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 100);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // panelFuncMenu
            // 
            this.panelFuncMenu.BackColor = System.Drawing.Color.AliceBlue;
            this.panelFuncMenu.Controls.Add(this.btnBar);
            this.panelFuncMenu.Controls.Add(this.btnBox);
            this.panelFuncMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFuncMenu.Location = new System.Drawing.Point(0, 145);
            this.panelFuncMenu.Name = "panelFuncMenu";
            this.panelFuncMenu.Size = new System.Drawing.Size(200, 80);
            this.panelFuncMenu.TabIndex = 1;
            // 
            // btnBox
            // 
            this.btnBox.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBox.Location = new System.Drawing.Point(0, 0);
            this.btnBox.Name = "btnBox";
            this.btnBox.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnBox.Size = new System.Drawing.Size(200, 40);
            this.btnBox.TabIndex = 0;
            this.btnBox.Text = "Box";
            this.btnBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBox.UseVisualStyleBackColor = false;
            this.btnBox.Click += new System.EventHandler(this.btnBox_Click);
            // 
            // btnBar
            // 
            this.btnBar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBar.Location = new System.Drawing.Point(0, 40);
            this.btnBar.Name = "btnBar";
            this.btnBar.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnBar.Size = new System.Drawing.Size(200, 40);
            this.btnBar.TabIndex = 2;
            this.btnBar.Text = "Bar";
            this.btnBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBar.UseVisualStyleBackColor = false;
            this.btnBar.Click += new System.EventHandler(this.btnBar_Click);
            // 
            // btnEtc
            // 
            this.btnEtc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEtc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtc.Font = new System.Drawing.Font("카페24 당당해", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEtc.ForeColor = System.Drawing.Color.Black;
            this.btnEtc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEtc.Location = new System.Drawing.Point(0, 225);
            this.btnEtc.Name = "btnEtc";
            this.btnEtc.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEtc.Size = new System.Drawing.Size(200, 45);
            this.btnEtc.TabIndex = 2;
            this.btnEtc.Text = "Etc";
            this.btnEtc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEtc.UseVisualStyleBackColor = true;
            this.btnEtc.Click += new System.EventHandler(this.btnEtc_Click);
            // 
            // panelEtcMenu
            // 
            this.panelEtcMenu.BackColor = System.Drawing.Color.AliceBlue;
            this.panelEtcMenu.Controls.Add(this.btnEtcEtc);
            this.panelEtcMenu.Controls.Add(this.btnPop);
            this.panelEtcMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEtcMenu.Location = new System.Drawing.Point(0, 270);
            this.panelEtcMenu.Name = "panelEtcMenu";
            this.panelEtcMenu.Size = new System.Drawing.Size(200, 80);
            this.panelEtcMenu.TabIndex = 3;
            // 
            // btnPop
            // 
            this.btnPop.BackColor = System.Drawing.Color.AliceBlue;
            this.btnPop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPop.Location = new System.Drawing.Point(0, 0);
            this.btnPop.Name = "btnPop";
            this.btnPop.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnPop.Size = new System.Drawing.Size(200, 40);
            this.btnPop.TabIndex = 1;
            this.btnPop.Text = "Pop";
            this.btnPop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPop.UseVisualStyleBackColor = false;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnEtcEtc
            // 
            this.btnEtcEtc.BackColor = System.Drawing.Color.AliceBlue;
            this.btnEtcEtc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEtcEtc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtcEtc.Location = new System.Drawing.Point(0, 40);
            this.btnEtcEtc.Name = "btnEtcEtc";
            this.btnEtcEtc.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnEtcEtc.Size = new System.Drawing.Size(200, 40);
            this.btnEtcEtc.TabIndex = 2;
            this.btnEtcEtc.Text = "Etc";
            this.btnEtcEtc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEtcEtc.UseVisualStyleBackColor = false;
            this.btnEtcEtc.Click += new System.EventHandler(this.btnEtcEtc_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("카페24 당당해", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCopy.ForeColor = System.Drawing.Color.Black;
            this.btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopy.Location = new System.Drawing.Point(0, 350);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCopy.Size = new System.Drawing.Size(200, 45);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "Copy";
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // panelWriteLog
            // 
            this.panelWriteLog.BackColor = System.Drawing.Color.White;
            this.panelWriteLog.Controls.Add(this.textLog);
            this.panelWriteLog.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelWriteLog.Location = new System.Drawing.Point(744, 0);
            this.panelWriteLog.Name = "panelWriteLog";
            this.panelWriteLog.Size = new System.Drawing.Size(300, 476);
            this.panelWriteLog.TabIndex = 1;
            // 
            // panelChild
            // 
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(200, 0);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(544, 476);
            this.panelChild.TabIndex = 2;
            // 
            // textLog
            // 
            this.textLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textLog.Location = new System.Drawing.Point(20, 18);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.ReadOnly = true;
            this.textLog.Size = new System.Drawing.Size(260, 440);
            this.textLog.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 476);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panelWriteLog);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.panelFuncMenu.ResumeLayout(false);
            this.panelEtcMenu.ResumeLayout(false);
            this.panelWriteLog.ResumeLayout(false);
            this.panelWriteLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelFuncMenu;
        private System.Windows.Forms.Button btnBar;
        private System.Windows.Forms.Button btnBox;
        private System.Windows.Forms.Button btnEtc;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Panel panelEtcMenu;
        private System.Windows.Forms.Button btnEtcEtc;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Panel panelWriteLog;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.TextBox textLog;
    }
}

