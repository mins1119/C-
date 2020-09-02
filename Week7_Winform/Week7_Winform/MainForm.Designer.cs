namespace Week7_Winform
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원가입ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RightSidePanel = new System.Windows.Forms.Panel();
            this.textLog = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Box = new System.Windows.Forms.TabPage();
            this.gridFruit = new System.Windows.Forms.DataGridView();
            this.SelectFruit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFruit = new System.Windows.Forms.Button();
            this.chkboxFruit = new System.Windows.Forms.CheckedListBox();
            this.grpFont = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblFont = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtSample = new System.Windows.Forms.TextBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.cboFont = new System.Windows.Forms.ComboBox();
            this.Bar = new System.Windows.Forms.TabPage();
            this.grpBtn = new System.Windows.Forms.GroupBox();
            this.btnMsgBox = new System.Windows.Forms.Button();
            this.btnModaless = new System.Windows.Forms.Button();
            this.btnModal = new System.Windows.Forms.Button();
            this.grpBar = new System.Windows.Forms.GroupBox();
            this.pgDummy = new System.Windows.Forms.ProgressBar();
            this.tbDummy = new System.Windows.Forms.TrackBar();
            this.LeftSidePanel = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusWriter = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.RightSidePanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFruit)).BeginInit();
            this.grpFont.SuspendLayout();
            this.Bar.SuspendLayout();
            this.grpBtn.SuspendLayout();
            this.grpBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDummy)).BeginInit();
            this.LeftSidePanel.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            exitToolStripMenuItem.Text = "끝내기";
            exitToolStripMenuItem.Click += new System.EventHandler(this.끝내ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 24);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.tabToolStripMenuItem,
            this.회원가입ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(819, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            exitToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.정보ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // 정보ToolStripMenuItem
            // 
            this.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem";
            this.정보ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.정보ToolStripMenuItem.Text = "정보";
            // 
            // 회원가입ToolStripMenuItem
            // 
            this.회원가입ToolStripMenuItem.Name = "회원가입ToolStripMenuItem";
            this.회원가입ToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.회원가입ToolStripMenuItem.Text = "회원";
            this.회원가입ToolStripMenuItem.Click += new System.EventHandler(this.회원가입ToolStripMenuItem_Click);
            // 
            // RightSidePanel
            // 
            this.RightSidePanel.Controls.Add(this.textLog);
            this.RightSidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightSidePanel.Location = new System.Drawing.Point(524, 24);
            this.RightSidePanel.Name = "RightSidePanel";
            this.RightSidePanel.Size = new System.Drawing.Size(295, 475);
            this.RightSidePanel.TabIndex = 2;
            // 
            // textLog
            // 
            this.textLog.AcceptsReturn = true;
            this.textLog.AcceptsTab = true;
            this.textLog.AllowDrop = true;
            this.textLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textLog.Font = new System.Drawing.Font("KoPubWorld돋움체 Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textLog.Location = new System.Drawing.Point(9, 22);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.ReadOnly = true;
            this.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textLog.Size = new System.Drawing.Size(277, 447);
            this.textLog.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Box);
            this.tabControl.Controls.Add(this.Bar);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(524, 475);
            this.tabControl.TabIndex = 0;
            // 
            // Box
            // 
            this.Box.Controls.Add(this.gridFruit);
            this.Box.Controls.Add(this.btnFruit);
            this.Box.Controls.Add(this.chkboxFruit);
            this.Box.Controls.Add(this.grpFont);
            this.Box.Location = new System.Drawing.Point(4, 22);
            this.Box.Name = "Box";
            this.Box.Padding = new System.Windows.Forms.Padding(3);
            this.Box.Size = new System.Drawing.Size(516, 449);
            this.Box.TabIndex = 0;
            this.Box.Text = "Box";
            this.Box.UseVisualStyleBackColor = true;
            // 
            // gridFruit
            // 
            this.gridFruit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFruit.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridFruit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridFruit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridFruit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFruit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectFruit});
            this.gridFruit.Location = new System.Drawing.Point(296, 28);
            this.gridFruit.Name = "gridFruit";
            this.gridFruit.ReadOnly = true;
            this.gridFruit.RowTemplate.Height = 23;
            this.gridFruit.ShowCellErrors = false;
            this.gridFruit.Size = new System.Drawing.Size(185, 84);
            this.gridFruit.TabIndex = 4;
            // 
            // SelectFruit
            // 
            this.SelectFruit.HeaderText = "SelectedFruit";
            this.SelectFruit.Name = "SelectFruit";
            this.SelectFruit.ReadOnly = true;
            // 
            // btnFruit
            // 
            this.btnFruit.Location = new System.Drawing.Point(193, 56);
            this.btnFruit.Name = "btnFruit";
            this.btnFruit.Size = new System.Drawing.Size(75, 23);
            this.btnFruit.TabIndex = 3;
            this.btnFruit.Text = "선택";
            this.btnFruit.UseVisualStyleBackColor = true;
            this.btnFruit.Click += new System.EventHandler(this.btnFruit_Click);
            // 
            // chkboxFruit
            // 
            this.chkboxFruit.CheckOnClick = true;
            this.chkboxFruit.FormattingEnabled = true;
            this.chkboxFruit.Items.AddRange(new object[] {
            "Apple",
            "Strawberry",
            "Pineapple",
            "Peach",
            "Starfruits",
            "Mangosteen"});
            this.chkboxFruit.Location = new System.Drawing.Point(45, 28);
            this.chkboxFruit.Name = "chkboxFruit";
            this.chkboxFruit.Size = new System.Drawing.Size(120, 84);
            this.chkboxFruit.TabIndex = 1;
            this.chkboxFruit.SelectedIndexChanged += new System.EventHandler(this.chkbobxFruit_SelectedIndexChanged);
            // 
            // grpFont
            // 
            this.grpFont.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFont.Controls.Add(this.lblResult);
            this.grpFont.Controls.Add(this.lblFont);
            this.grpFont.Controls.Add(this.txtResult);
            this.grpFont.Controls.Add(this.txtSample);
            this.grpFont.Controls.Add(this.chkItalic);
            this.grpFont.Controls.Add(this.chkBold);
            this.grpFont.Controls.Add(this.cboFont);
            this.grpFont.Location = new System.Drawing.Point(45, 216);
            this.grpFont.Name = "grpFont";
            this.grpFont.Size = new System.Drawing.Size(436, 184);
            this.grpFont.TabIndex = 0;
            this.grpFont.TabStop = false;
            this.grpFont.Text = "ComboBox, CheckBox, TextBox";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult.Location = new System.Drawing.Point(42, 117);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(58, 15);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result :";
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFont.Location = new System.Drawing.Point(42, 80);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(51, 15);
            this.lblFont.TabIndex = 5;
            this.lblFont.Text = "Font : ";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(103, 114);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(270, 21);
            this.txtResult.TabIndex = 4;
            // 
            // txtSample
            // 
            this.txtSample.Location = new System.Drawing.Point(44, 41);
            this.txtSample.Name = "txtSample";
            this.txtSample.Size = new System.Drawing.Size(329, 21);
            this.txtSample.TabIndex = 3;
            this.txtSample.Text = "Hello";
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkItalic.Location = new System.Drawing.Point(322, 79);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(51, 16);
            this.chkItalic.TabIndex = 2;
            this.chkItalic.Text = "Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckStateChanged += new System.EventHandler(this.chkItalic_CheckStateChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkBold.Location = new System.Drawing.Point(240, 79);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(53, 16);
            this.chkBold.TabIndex = 1;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckStateChanged += new System.EventHandler(this.chkBold_CheckStateChanged);
            // 
            // cboFont
            // 
            this.cboFont.FormattingEnabled = true;
            this.cboFont.Location = new System.Drawing.Point(103, 77);
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(121, 20);
            this.cboFont.TabIndex = 0;
            this.cboFont.SelectedIndexChanged += new System.EventHandler(this.cboFont_SelectedIndexChanged);
            // 
            // Bar
            // 
            this.Bar.Controls.Add(this.grpBtn);
            this.Bar.Controls.Add(this.grpBar);
            this.Bar.Location = new System.Drawing.Point(4, 22);
            this.Bar.Name = "Bar";
            this.Bar.Padding = new System.Windows.Forms.Padding(3);
            this.Bar.Size = new System.Drawing.Size(516, 449);
            this.Bar.TabIndex = 1;
            this.Bar.Text = "Bar & Button";
            this.Bar.UseVisualStyleBackColor = true;
            // 
            // grpBtn
            // 
            this.grpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBtn.Controls.Add(this.btnMsgBox);
            this.grpBtn.Controls.Add(this.btnModaless);
            this.grpBtn.Controls.Add(this.btnModal);
            this.grpBtn.Location = new System.Drawing.Point(28, 50);
            this.grpBtn.Name = "grpBtn";
            this.grpBtn.Size = new System.Drawing.Size(452, 124);
            this.grpBtn.TabIndex = 1;
            this.grpBtn.TabStop = false;
            this.grpBtn.Text = "Modal & Modales & Message";
            // 
            // btnMsgBox
            // 
            this.btnMsgBox.Location = new System.Drawing.Point(295, 56);
            this.btnMsgBox.Name = "btnMsgBox";
            this.btnMsgBox.Size = new System.Drawing.Size(115, 21);
            this.btnMsgBox.TabIndex = 2;
            this.btnMsgBox.Text = "Message";
            this.btnMsgBox.UseVisualStyleBackColor = true;
            this.btnMsgBox.Click += new System.EventHandler(this.btnMsgBox_Click);
            // 
            // btnModaless
            // 
            this.btnModaless.Location = new System.Drawing.Point(153, 56);
            this.btnModaless.Name = "btnModaless";
            this.btnModaless.Size = new System.Drawing.Size(109, 21);
            this.btnModaless.TabIndex = 1;
            this.btnModaless.Text = "Modaless";
            this.btnModaless.UseVisualStyleBackColor = true;
            this.btnModaless.Click += new System.EventHandler(this.btnModaless_Click);
            // 
            // btnModal
            // 
            this.btnModal.Location = new System.Drawing.Point(32, 56);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(85, 21);
            this.btnModal.TabIndex = 0;
            this.btnModal.Text = "Modal";
            this.btnModal.UseVisualStyleBackColor = true;
            this.btnModal.Click += new System.EventHandler(this.btnModal_Click);
            // 
            // grpBar
            // 
            this.grpBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBar.Controls.Add(this.pgDummy);
            this.grpBar.Controls.Add(this.tbDummy);
            this.grpBar.Location = new System.Drawing.Point(28, 227);
            this.grpBar.Name = "grpBar";
            this.grpBar.Size = new System.Drawing.Size(452, 193);
            this.grpBar.TabIndex = 0;
            this.grpBar.TabStop = false;
            this.grpBar.Text = "TrackBar & ProgressBar";
            // 
            // pgDummy
            // 
            this.pgDummy.Location = new System.Drawing.Point(32, 117);
            this.pgDummy.Maximum = 26;
            this.pgDummy.Name = "pgDummy";
            this.pgDummy.Size = new System.Drawing.Size(378, 23);
            this.pgDummy.TabIndex = 1;
            // 
            // tbDummy
            // 
            this.tbDummy.Location = new System.Drawing.Point(32, 43);
            this.tbDummy.Maximum = 26;
            this.tbDummy.Name = "tbDummy";
            this.tbDummy.Size = new System.Drawing.Size(378, 45);
            this.tbDummy.TabIndex = 0;
            this.tbDummy.Scroll += new System.EventHandler(this.tbDummy_Scroll);
            // 
            // LeftSidePanel
            // 
            this.LeftSidePanel.Controls.Add(this.tabControl);
            this.LeftSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftSidePanel.Location = new System.Drawing.Point(0, 24);
            this.LeftSidePanel.Name = "LeftSidePanel";
            this.LeftSidePanel.Size = new System.Drawing.Size(524, 475);
            this.LeftSidePanel.TabIndex = 1;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.statusStrip);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 499);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(819, 21);
            this.panelBottom.TabIndex = 4;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusWriter,
            this.StatusTimer});
            this.statusStrip.Location = new System.Drawing.Point(0, -1);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(819, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip2";
            // 
            // StatusWriter
            // 
            this.StatusWriter.Name = "StatusWriter";
            this.StatusWriter.Size = new System.Drawing.Size(90, 17);
            this.StatusWriter.Text = "작성자 : 강민서";
            // 
            // StatusTimer
            // 
            this.StatusTimer.Name = "StatusTimer";
            this.StatusTimer.Size = new System.Drawing.Size(714, 17);
            this.StatusTimer.Spring = true;
            this.StatusTimer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tabToolStripMenuItem
            // 
            this.tabToolStripMenuItem.Name = "tabToolStripMenuItem";
            this.tabToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.tabToolStripMenuItem.Text = "Tab";
            this.tabToolStripMenuItem.Click += new System.EventHandler(this.tabToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 520);
            this.Controls.Add(this.RightSidePanel);
            this.Controls.Add(this.LeftSidePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBottom);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "WinForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.RightSidePanel.ResumeLayout(false);
            this.RightSidePanel.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.Box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFruit)).EndInit();
            this.grpFont.ResumeLayout(false);
            this.grpFont.PerformLayout();
            this.Bar.ResumeLayout(false);
            this.grpBtn.ResumeLayout(false);
            this.grpBar.ResumeLayout(false);
            this.grpBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDummy)).EndInit();
            this.LeftSidePanel.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel RightSidePanel;
        private System.Windows.Forms.TextBox textLog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Box;
        private System.Windows.Forms.DataGridView gridFruit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectFruit;
        private System.Windows.Forms.Button btnFruit;
        private System.Windows.Forms.CheckedListBox chkboxFruit;
        private System.Windows.Forms.GroupBox grpFont;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtSample;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.ComboBox cboFont;
        private System.Windows.Forms.TabPage Bar;
        private System.Windows.Forms.GroupBox grpBar;
        private System.Windows.Forms.ProgressBar pgDummy;
        private System.Windows.Forms.TrackBar tbDummy;
        private System.Windows.Forms.Panel LeftSidePanel;
        private System.Windows.Forms.GroupBox grpBtn;
        private System.Windows.Forms.Button btnMsgBox;
        private System.Windows.Forms.Button btnModaless;
        private System.Windows.Forms.Button btnModal;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusWriter;
        private System.Windows.Forms.ToolStripStatusLabel StatusTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ToolStripMenuItem 회원가입ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabToolStripMenuItem;
    }
}

