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
            this.회원가입ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원목록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RightSidePanel = new System.Windows.Forms.Panel();
            this.textLog = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Bar = new System.Windows.Forms.TabPage();
            this.grpBtn = new System.Windows.Forms.GroupBox();
            this.btnMsgBox = new System.Windows.Forms.Button();
            this.btnModaless = new System.Windows.Forms.Button();
            this.btnModal = new System.Windows.Forms.Button();
            this.grpBar = new System.Windows.Forms.GroupBox();
            this.pgDummy = new System.Windows.Forms.ProgressBar();
            this.tbDummy = new System.Windows.Forms.TrackBar();
            this.Box = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridFruit = new System.Windows.Forms.DataGridView();
            this.SelectFruit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFruit = new System.Windows.Forms.Button();
            this.chkboxFruit = new System.Windows.Forms.CheckedListBox();
            this.grpFont = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblFont = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtSample = new System.Windows.Forms.TextBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.cboFont = new System.Windows.Forms.ComboBox();
            this.LeftSidePanel = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusWriter = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.grpFileCopy = new System.Windows.Forms.GroupBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.btnAsyncCopy = new System.Windows.Forms.Button();
            this.btnSyncCopy = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFindSource = new System.Windows.Forms.Button();
            this.btnFindTarget = new System.Windows.Forms.Button();
            this.pbCopy = new System.Windows.Forms.ProgressBar();
            this.ControlView = new System.Windows.Forms.TabPage();
            this.grpTreeList = new System.Windows.Forms.GroupBox();
            this.lvDummy = new System.Windows.Forms.ListView();
            this.tvDummy = new System.Windows.Forms.TreeView();
            this.btnAddRoot = new System.Windows.Forms.Button();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.grpControl = new System.Windows.Forms.GroupBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnMouseEvent = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.RightSidePanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.Bar.SuspendLayout();
            this.grpBtn.SuspendLayout();
            this.grpBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDummy)).BeginInit();
            this.Box.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFruit)).BeginInit();
            this.grpFont.SuspendLayout();
            this.panel2.SuspendLayout();
            this.LeftSidePanel.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.grpFileCopy.SuspendLayout();
            this.ControlView.SuspendLayout();
            this.grpTreeList.SuspendLayout();
            this.grpControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            exitToolStripMenuItem.Text = "끝내기";
            exitToolStripMenuItem.Click += new System.EventHandler(this.끝내ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 25);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.회원가입ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1055, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            exitToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 19);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 회원가입ToolStripMenuItem
            // 
            this.회원가입ToolStripMenuItem.AutoSize = false;
            this.회원가입ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.회원가입ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.회원등록ToolStripMenuItem,
            this.회원목록ToolStripMenuItem});
            this.회원가입ToolStripMenuItem.Name = "회원가입ToolStripMenuItem";
            this.회원가입ToolStripMenuItem.Size = new System.Drawing.Size(43, 19);
            this.회원가입ToolStripMenuItem.Text = "회원";
            // 
            // 회원등록ToolStripMenuItem
            // 
            this.회원등록ToolStripMenuItem.Name = "회원등록ToolStripMenuItem";
            this.회원등록ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.회원등록ToolStripMenuItem.Text = "회원 가입";
            this.회원등록ToolStripMenuItem.Click += new System.EventHandler(this.회원등록ToolStripMenuItem_Click);
            // 
            // 회원목록ToolStripMenuItem
            // 
            this.회원목록ToolStripMenuItem.Name = "회원목록ToolStripMenuItem";
            this.회원목록ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.회원목록ToolStripMenuItem.Text = "회원 목록";
            this.회원목록ToolStripMenuItem.Click += new System.EventHandler(this.회원목록ToolStripMenuItem_Click);
            // 
            // RightSidePanel
            // 
            this.RightSidePanel.Controls.Add(this.textLog);
            this.RightSidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightSidePanel.Location = new System.Drawing.Point(736, 25);
            this.RightSidePanel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.RightSidePanel.Name = "RightSidePanel";
            this.RightSidePanel.Size = new System.Drawing.Size(319, 535);
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
            this.textLog.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textLog.Font = new System.Drawing.Font("KoPubWorld돋움체 Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textLog.Location = new System.Drawing.Point(9, 28);
            this.textLog.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.ReadOnly = true;
            this.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textLog.Size = new System.Drawing.Size(298, 502);
            this.textLog.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Box);
            this.tabControl.Controls.Add(this.Bar);
            this.tabControl.Controls.Add(this.ControlView);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(3, 3);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(736, 535);
            this.tabControl.TabIndex = 0;
            // 
            // Bar
            // 
            this.Bar.Controls.Add(this.grpFileCopy);
            this.Bar.Controls.Add(this.grpBtn);
            this.Bar.Controls.Add(this.grpBar);
            this.Bar.Location = new System.Drawing.Point(4, 28);
            this.Bar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Bar.Name = "Bar";
            this.Bar.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Bar.Size = new System.Drawing.Size(728, 503);
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
            this.grpBtn.Location = new System.Drawing.Point(32, 42);
            this.grpBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpBtn.Name = "grpBtn";
            this.grpBtn.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpBtn.Size = new System.Drawing.Size(654, 71);
            this.grpBtn.TabIndex = 1;
            this.grpBtn.TabStop = false;
            this.grpBtn.Text = "Modal & Modales & Message";
            // 
            // btnMsgBox
            // 
            this.btnMsgBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMsgBox.Location = new System.Drawing.Point(411, 29);
            this.btnMsgBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnMsgBox.Name = "btnMsgBox";
            this.btnMsgBox.Size = new System.Drawing.Size(130, 31);
            this.btnMsgBox.TabIndex = 2;
            this.btnMsgBox.Text = "Message";
            this.btnMsgBox.UseVisualStyleBackColor = true;
            this.btnMsgBox.Click += new System.EventHandler(this.btnMsgBox_Click);
            // 
            // btnModaless
            // 
            this.btnModaless.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModaless.Location = new System.Drawing.Point(258, 29);
            this.btnModaless.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnModaless.Name = "btnModaless";
            this.btnModaless.Size = new System.Drawing.Size(125, 31);
            this.btnModaless.TabIndex = 1;
            this.btnModaless.Text = "Modaless";
            this.btnModaless.UseVisualStyleBackColor = true;
            this.btnModaless.Click += new System.EventHandler(this.btnModaless_Click);
            // 
            // btnModal
            // 
            this.btnModal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModal.Location = new System.Drawing.Point(109, 29);
            this.btnModal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(117, 31);
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
            this.grpBar.Location = new System.Drawing.Point(32, 133);
            this.grpBar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpBar.Name = "grpBar";
            this.grpBar.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpBar.Size = new System.Drawing.Size(654, 128);
            this.grpBar.TabIndex = 0;
            this.grpBar.TabStop = false;
            this.grpBar.Text = "TrackBar & ProgressBar";
            // 
            // pgDummy
            // 
            this.pgDummy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pgDummy.Location = new System.Drawing.Point(109, 83);
            this.pgDummy.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pgDummy.Maximum = 26;
            this.pgDummy.Name = "pgDummy";
            this.pgDummy.Size = new System.Drawing.Size(432, 26);
            this.pgDummy.TabIndex = 1;
            // 
            // tbDummy
            // 
            this.tbDummy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDummy.Location = new System.Drawing.Point(109, 28);
            this.tbDummy.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbDummy.Maximum = 26;
            this.tbDummy.Name = "tbDummy";
            this.tbDummy.Size = new System.Drawing.Size(432, 45);
            this.tbDummy.TabIndex = 0;
            this.tbDummy.Scroll += new System.EventHandler(this.tbDummy_Scroll);
            // 
            // Box
            // 
            this.Box.Controls.Add(this.panel3);
            this.Box.Controls.Add(this.grpFont);
            this.Box.Location = new System.Drawing.Point(4, 28);
            this.Box.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Box.Name = "Box";
            this.Box.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Box.Size = new System.Drawing.Size(728, 503);
            this.Box.TabIndex = 0;
            this.Box.Text = "Box";
            this.Box.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridFruit);
            this.panel3.Controls.Add(this.btnFruit);
            this.panel3.Controls.Add(this.chkboxFruit);
            this.panel3.Location = new System.Drawing.Point(51, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(638, 179);
            this.panel3.TabIndex = 5;
            // 
            // gridFruit
            // 
            this.gridFruit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFruit.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridFruit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridFruit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridFruit.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.gridFruit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFruit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectFruit});
            this.gridFruit.Location = new System.Drawing.Point(378, 26);
            this.gridFruit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gridFruit.Name = "gridFruit";
            this.gridFruit.ReadOnly = true;
            this.gridFruit.RowTemplate.Height = 23;
            this.gridFruit.ShowCellErrors = false;
            this.gridFruit.Size = new System.Drawing.Size(211, 130);
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
            this.btnFruit.Location = new System.Drawing.Point(238, 74);
            this.btnFruit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnFruit.Name = "btnFruit";
            this.btnFruit.Size = new System.Drawing.Size(86, 36);
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
            this.chkboxFruit.Location = new System.Drawing.Point(51, 26);
            this.chkboxFruit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chkboxFruit.Name = "chkboxFruit";
            this.chkboxFruit.Size = new System.Drawing.Size(137, 130);
            this.chkboxFruit.TabIndex = 1;
            this.chkboxFruit.SelectedIndexChanged += new System.EventHandler(this.chkbobxFruit_SelectedIndexChanged);
            // 
            // grpFont
            // 
            this.grpFont.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFont.Controls.Add(this.panel2);
            this.grpFont.Location = new System.Drawing.Point(51, 246);
            this.grpFont.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpFont.Name = "grpFont";
            this.grpFont.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpFont.Size = new System.Drawing.Size(635, 214);
            this.grpFont.TabIndex = 0;
            this.grpFont.TabStop = false;
            this.grpFont.Text = "ComboBox, CheckBox, TextBox";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.Controls.Add(this.lblResult);
            this.panel2.Controls.Add(this.lblFont);
            this.panel2.Controls.Add(this.txtResult);
            this.panel2.Controls.Add(this.txtSample);
            this.panel2.Controls.Add(this.chkItalic);
            this.panel2.Controls.Add(this.chkBold);
            this.panel2.Controls.Add(this.cboFont);
            this.panel2.Location = new System.Drawing.Point(98, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 152);
            this.panel2.TabIndex = 7;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult.Location = new System.Drawing.Point(30, 115);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(58, 15);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result :";
            // 
            // lblFont
            // 
            this.lblFont.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFont.AutoSize = true;
            this.lblFont.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFont.Location = new System.Drawing.Point(30, 64);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(51, 15);
            this.lblFont.TabIndex = 5;
            this.lblFont.Text = "Font : ";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtResult.Location = new System.Drawing.Point(100, 110);
            this.txtResult.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(303, 26);
            this.txtResult.TabIndex = 4;
            // 
            // txtSample
            // 
            this.txtSample.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSample.Location = new System.Drawing.Point(33, 21);
            this.txtSample.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSample.Name = "txtSample";
            this.txtSample.Size = new System.Drawing.Size(370, 26);
            this.txtSample.TabIndex = 3;
            this.txtSample.Text = "Hello";
            // 
            // chkItalic
            // 
            this.chkItalic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkItalic.Location = new System.Drawing.Point(352, 62);
            this.chkItalic.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(51, 16);
            this.chkItalic.TabIndex = 2;
            this.chkItalic.Text = "Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckStateChanged += new System.EventHandler(this.chkItalic_CheckStateChanged);
            // 
            // chkBold
            // 
            this.chkBold.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkBold.Location = new System.Drawing.Point(264, 64);
            this.chkBold.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(53, 16);
            this.chkBold.TabIndex = 1;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckStateChanged += new System.EventHandler(this.chkBold_CheckStateChanged);
            // 
            // cboFont
            // 
            this.cboFont.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboFont.FormattingEnabled = true;
            this.cboFont.Location = new System.Drawing.Point(100, 57);
            this.cboFont.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(134, 27);
            this.cboFont.TabIndex = 0;
            this.cboFont.SelectedIndexChanged += new System.EventHandler(this.cboFont_SelectedIndexChanged);
            // 
            // LeftSidePanel
            // 
            this.LeftSidePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LeftSidePanel.Controls.Add(this.tabControl);
            this.LeftSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftSidePanel.Location = new System.Drawing.Point(0, 25);
            this.LeftSidePanel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.LeftSidePanel.Name = "LeftSidePanel";
            this.LeftSidePanel.Size = new System.Drawing.Size(736, 535);
            this.LeftSidePanel.TabIndex = 1;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.statusStrip);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 560);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1055, 33);
            this.panelBottom.TabIndex = 4;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusWriter,
            this.StatusTimer});
            this.statusStrip.Location = new System.Drawing.Point(0, 11);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(1055, 22);
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
            this.StatusTimer.Size = new System.Drawing.Size(948, 17);
            this.StatusTimer.Spring = true;
            this.StatusTimer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // grpFileCopy
            // 
            this.grpFileCopy.Controls.Add(this.pbCopy);
            this.grpFileCopy.Controls.Add(this.btnFindTarget);
            this.grpFileCopy.Controls.Add(this.btnFindSource);
            this.grpFileCopy.Controls.Add(this.btnCancel);
            this.grpFileCopy.Controls.Add(this.btnSyncCopy);
            this.grpFileCopy.Controls.Add(this.btnAsyncCopy);
            this.grpFileCopy.Controls.Add(this.txtTarget);
            this.grpFileCopy.Controls.Add(this.txtSource);
            this.grpFileCopy.Controls.Add(this.lblTarget);
            this.grpFileCopy.Controls.Add(this.lblSource);
            this.grpFileCopy.Location = new System.Drawing.Point(32, 283);
            this.grpFileCopy.Name = "grpFileCopy";
            this.grpFileCopy.Size = new System.Drawing.Size(654, 203);
            this.grpFileCopy.TabIndex = 2;
            this.grpFileCopy.TabStop = false;
            this.grpFileCopy.Text = "File Copy";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(105, 28);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(66, 19);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Source : ";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(105, 70);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(62, 19);
            this.lblTarget.TabIndex = 1;
            this.lblTarget.Text = "Target : ";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(191, 25);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(266, 26);
            this.txtSource.TabIndex = 2;
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(191, 67);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(266, 26);
            this.txtTarget.TabIndex = 3;
            // 
            // btnAsyncCopy
            // 
            this.btnAsyncCopy.Location = new System.Drawing.Point(109, 115);
            this.btnAsyncCopy.Name = "btnAsyncCopy";
            this.btnAsyncCopy.Size = new System.Drawing.Size(94, 23);
            this.btnAsyncCopy.TabIndex = 4;
            this.btnAsyncCopy.Text = "AsyncCopy";
            this.btnAsyncCopy.UseVisualStyleBackColor = true;
            this.btnAsyncCopy.Click += new System.EventHandler(this.btnAsyncCopy_Click);
            // 
            // btnSyncCopy
            // 
            this.btnSyncCopy.Location = new System.Drawing.Point(280, 115);
            this.btnSyncCopy.Name = "btnSyncCopy";
            this.btnSyncCopy.Size = new System.Drawing.Size(89, 23);
            this.btnSyncCopy.TabIndex = 5;
            this.btnSyncCopy.Text = "SyncCopy";
            this.btnSyncCopy.UseVisualStyleBackColor = true;
            this.btnSyncCopy.Click += new System.EventHandler(this.btnSyncCopy_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(466, 115);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFindSource
            // 
            this.btnFindSource.Location = new System.Drawing.Point(489, 26);
            this.btnFindSource.Name = "btnFindSource";
            this.btnFindSource.Size = new System.Drawing.Size(52, 23);
            this.btnFindSource.TabIndex = 7;
            this.btnFindSource.Text = "...";
            this.btnFindSource.UseVisualStyleBackColor = true;
            this.btnFindSource.Click += new System.EventHandler(this.btnFindSource_Click);
            // 
            // btnFindTarget
            // 
            this.btnFindTarget.Location = new System.Drawing.Point(489, 68);
            this.btnFindTarget.Name = "btnFindTarget";
            this.btnFindTarget.Size = new System.Drawing.Size(52, 23);
            this.btnFindTarget.TabIndex = 8;
            this.btnFindTarget.Text = "...";
            this.btnFindTarget.UseVisualStyleBackColor = true;
            this.btnFindTarget.Click += new System.EventHandler(this.btnFindTarget_Click);
            // 
            // pbCopy
            // 
            this.pbCopy.Location = new System.Drawing.Point(109, 157);
            this.pbCopy.Name = "pbCopy";
            this.pbCopy.Size = new System.Drawing.Size(432, 27);
            this.pbCopy.TabIndex = 9;
            // 
            // ControlView
            // 
            this.ControlView.Controls.Add(this.grpControl);
            this.ControlView.Controls.Add(this.grpTreeList);
            this.ControlView.Location = new System.Drawing.Point(4, 28);
            this.ControlView.Name = "ControlView";
            this.ControlView.Padding = new System.Windows.Forms.Padding(3);
            this.ControlView.Size = new System.Drawing.Size(728, 503);
            this.ControlView.TabIndex = 2;
            this.ControlView.Text = "Control & View";
            this.ControlView.UseVisualStyleBackColor = true;
            // 
            // grpTreeList
            // 
            this.grpTreeList.Controls.Add(this.btnAddChild);
            this.grpTreeList.Controls.Add(this.btnAddRoot);
            this.grpTreeList.Controls.Add(this.tvDummy);
            this.grpTreeList.Controls.Add(this.lvDummy);
            this.grpTreeList.Location = new System.Drawing.Point(72, 228);
            this.grpTreeList.Name = "grpTreeList";
            this.grpTreeList.Size = new System.Drawing.Size(587, 242);
            this.grpTreeList.TabIndex = 0;
            this.grpTreeList.TabStop = false;
            this.grpTreeList.Text = "TreeView & ListView";
            // 
            // lvDummy
            // 
            this.lvDummy.HideSelection = false;
            this.lvDummy.Location = new System.Drawing.Point(371, 39);
            this.lvDummy.Name = "lvDummy";
            this.lvDummy.Size = new System.Drawing.Size(181, 173);
            this.lvDummy.TabIndex = 0;
            this.lvDummy.UseCompatibleStateImageBehavior = false;
            // 
            // tvDummy
            // 
            this.tvDummy.Location = new System.Drawing.Point(31, 39);
            this.tvDummy.Name = "tvDummy";
            this.tvDummy.Size = new System.Drawing.Size(192, 173);
            this.tvDummy.TabIndex = 1;
            // 
            // btnAddRoot
            // 
            this.btnAddRoot.Location = new System.Drawing.Point(257, 68);
            this.btnAddRoot.Name = "btnAddRoot";
            this.btnAddRoot.Size = new System.Drawing.Size(85, 23);
            this.btnAddRoot.TabIndex = 2;
            this.btnAddRoot.Text = "루트 추가";
            this.btnAddRoot.UseVisualStyleBackColor = true;
            this.btnAddRoot.Click += new System.EventHandler(this.btnAddRoot_Click);
            // 
            // btnAddChild
            // 
            this.btnAddChild.Location = new System.Drawing.Point(257, 159);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(85, 23);
            this.btnAddChild.TabIndex = 3;
            this.btnAddChild.Text = "자식 추가";
            this.btnAddChild.UseVisualStyleBackColor = true;
            this.btnAddChild.Click += new System.EventHandler(this.btnAddChild_Click);
            // 
            // grpControl
            // 
            this.grpControl.Controls.Add(this.btnFolder);
            this.grpControl.Controls.Add(this.btnMouseEvent);
            this.grpControl.Controls.Add(this.btnColor);
            this.grpControl.Location = new System.Drawing.Point(72, 33);
            this.grpControl.Name = "grpControl";
            this.grpControl.Size = new System.Drawing.Size(587, 150);
            this.grpControl.TabIndex = 1;
            this.grpControl.TabStop = false;
            this.grpControl.Text = "Event";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(31, 61);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(108, 23);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "ColorPick";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnMouseEvent
            // 
            this.btnMouseEvent.Location = new System.Drawing.Point(236, 61);
            this.btnMouseEvent.Name = "btnMouseEvent";
            this.btnMouseEvent.Size = new System.Drawing.Size(125, 23);
            this.btnMouseEvent.TabIndex = 1;
            this.btnMouseEvent.Text = "MouseEvent";
            this.btnMouseEvent.UseVisualStyleBackColor = true;
            this.btnMouseEvent.Click += new System.EventHandler(this.btnMouseEvent_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(477, 61);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(75, 23);
            this.btnFolder.TabIndex = 2;
            this.btnFolder.Text = "Folder";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1055, 593);
            this.Controls.Add(this.RightSidePanel);
            this.Controls.Add(this.LeftSidePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBottom);
            this.Font = new System.Drawing.Font("KoPubWorld돋움체 Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.RightSidePanel.ResumeLayout(false);
            this.RightSidePanel.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.Bar.ResumeLayout(false);
            this.grpBtn.ResumeLayout(false);
            this.grpBar.ResumeLayout(false);
            this.grpBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDummy)).EndInit();
            this.Box.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFruit)).EndInit();
            this.grpFont.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.LeftSidePanel.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.grpFileCopy.ResumeLayout(false);
            this.grpFileCopy.PerformLayout();
            this.ControlView.ResumeLayout(false);
            this.grpTreeList.ResumeLayout(false);
            this.grpControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel RightSidePanel;
        private System.Windows.Forms.TextBox textLog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
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
        private System.Windows.Forms.ToolStripMenuItem 회원가입ToolStripMenuItem;
        private System.Windows.Forms.TabPage Box;
        private System.Windows.Forms.DataGridView gridFruit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectFruit;
        private System.Windows.Forms.Button btnFruit;
        private System.Windows.Forms.CheckedListBox chkboxFruit;
        private System.Windows.Forms.GroupBox grpFont;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtSample;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.ComboBox cboFont;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem 회원등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원목록ToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpFileCopy;
        private System.Windows.Forms.ProgressBar pbCopy;
        private System.Windows.Forms.Button btnFindTarget;
        private System.Windows.Forms.Button btnFindSource;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSyncCopy;
        private System.Windows.Forms.Button btnAsyncCopy;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TabPage ControlView;
        private System.Windows.Forms.GroupBox grpTreeList;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.Button btnAddRoot;
        private System.Windows.Forms.TreeView tvDummy;
        private System.Windows.Forms.ListView lvDummy;
        private System.Windows.Forms.GroupBox grpControl;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnMouseEvent;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

