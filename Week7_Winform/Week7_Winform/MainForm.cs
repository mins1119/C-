using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7_Winform
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families;
            foreach (FontFamily font in Fonts)
                cboFont.Items.Add(font.Name);

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            StatusTimer.Text = String.Format($"{DateTime.Now.ToShortDateString()} {DateTime.Now.Hour}시 {DateTime.Now.Minute}분");
        }

        private void 끝내ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region : SelectBox
        private void chkbobxFruit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkboxFruit.GetItemChecked(chkboxFruit.SelectedIndex) == true)
            {
                textLog.AppendText($"{chkboxFruit.SelectedItem}이 선택 되었습니다.\r\n");
            }
            else
                textLog.AppendText($"{chkboxFruit.SelectedItem}이 해제 되었습니다.\r\n");
        }

        private void btnFruit_Click(object sender, EventArgs e)
        {
            gridFruit.Rows.Clear();
            for (int i = 0; i < chkboxFruit.CheckedItems.Count; i++)
            {
                gridFruit.Rows.Add(chkboxFruit.CheckedItems[i]);
            }
        }
        #endregion

        #region FontChange : 폰트 이벤트
        void ChangeFont()
        {
            FontStyle style = FontStyle.Regular;

            if (chkBold.Checked)
            {
                style |= FontStyle.Bold;
            }
            if (chkItalic.Checked)
            {
                style |= FontStyle.Italic;
            }
            if (cboFont.SelectedIndex < 0)
                return;

            txtResult.Text = txtSample.Text;
            txtResult.Font = new Font((string)cboFont.SelectedItem, 10, style);


        }
        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
            textLog.AppendText("폰트가 변경되었습니다.\r\n");
        }
        private void chkBold_CheckStateChanged(object sender, EventArgs e)
        {
            ChangeFont();
            if (chkBold.Checked)
                textLog.AppendText("Bold 체크\r\n");
            else
                textLog.AppendText("Bold 체크 해제\r\n");
        }
        private void chkItalic_CheckStateChanged(object sender, EventArgs e)
        {
            ChangeFont();
            if (chkItalic.Checked)
                textLog.AppendText("Italic 체크\r\n");
            else
                textLog.AppendText("Italic 체크 해제\r\n");
        }
        #endregion

        private void tbDummy_Scroll(object sender, EventArgs e)
        {
            pgDummy.Value = tbDummy.Value;
            textLog.AppendText($"값 : {tbDummy.Value}\r\n");    
        }

        #region Button : 버튼 이벤트
        private void btnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modal Form";
            frm.Width = 300;
            frm.Height = 300;
            frm.BackColor = Color.Red;
            frm.ShowDialog();
            textLog.AppendText("Modal 창 열기\r\n");
        }

        private void btnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modaless Form";
            frm.Width = 300;
            frm.Height = 300;
            frm.BackColor = Color.Blue;
            frm.Show();
            textLog.AppendText("Modaless 창 열기\r\n");

        }

        private void btnMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("메세지 박스입니다.",
                "MessageBox Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textLog.AppendText("MessageBox 창 열기\r\n");
        }
        #endregion

        private void 회원가입ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textLog.Text = "실행";
            LeftSidePanel.Visible = false;
            Week7_Winform.Example.RegisterForm rgForm = new Week7_Winform.Example.RegisterForm();
            rgForm.MdiParent = this;
            rgForm.Show();
        }

        private void tabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeftSidePanel.Visible = true;
        }
    }
}
