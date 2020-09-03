using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7_Winform
{
    public partial class MainForm : Form
    {
        Random random = new Random(37);
        public MainForm()
        {
            InitializeComponent();

            lvDummy.Columns.Add("Name");
            lvDummy.Columns.Add("Depth");
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
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("종료하시겠습니까?", "종료 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
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


        #region 회원관리
        private void 회원등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textLog.Text = "회원 가입\r\n";
            Example.RegisterForm rgForm = new Example.RegisterForm();
            rgForm.Show();
        }

        private void 회원목록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Example.PeopleListForm plForm = new Example.PeopleListForm();
            plForm.Show();
        }
        #endregion


        #region : 파일 복사
        private async Task<long> CopyAsync(string FromPath, string ToPath)
        {
            btnSyncCopy.Enabled = false;
            long totalCopied = 0;

            using(FileStream fromStream = new FileStream(FromPath,FileMode.Open))
            {
                using (FileStream toStream = new FileStream(ToPath, FileMode.Create))
                {
                    byte[] buffer = new byte[1024 * 1024];
                    int nRead = 0;
                    while((nRead = await fromStream.ReadAsync(buffer,0,buffer.Length)) != 0)
                    {
                        await toStream.WriteAsync(buffer, 0, nRead);
                        totalCopied += nRead;

                        pbCopy.Value = (int)(((double)totalCopied / (double)fromStream.Length) * pbCopy.Maximum);

                    }
                }
            }
            btnSyncCopy.Enabled = true;
            return totalCopied;
        }

        private long CopySync(string FromPath, string ToPath)
        {
            btnAsyncCopy.Enabled = false;
            long totalCopied = 0;

            using(FileStream fromStream = new FileStream(FromPath, FileMode.Open))
            {
                using (FileStream toStream = new FileStream(ToPath, FileMode.Create))
                {
                    byte[] buffer = new byte[1024 * 1024];
                    int nRead = 0;
                    while ((nRead = fromStream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        toStream.Write(buffer, 0, nRead);
                        totalCopied += nRead;
                        pbCopy.Value = (int)(((double)totalCopied / (double)fromStream.Length) * pbCopy.Maximum);
                    }
                }
            }
            btnAsyncCopy.Enabled = true;
            return totalCopied;
        }

        private void btnFindSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if(dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtSource.Text = dlg.FileName;
            }
        }

        private void btnFindTarget_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if(dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtTarget.Text = dlg.FileName;
            }
        }

        private async void btnAsyncCopy_Click(object sender, EventArgs e)
        {
            long totalCopied = await CopyAsync(txtSource.Text, txtTarget.Text);
        }

        private void btnSyncCopy_Click(object sender, EventArgs e)
        {
            long totalCopied = CopySync(txtSource.Text, txtTarget.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UI테스트 반응 성공");
        }

        #endregion

        #region : 트리뷰 & 리스트뷰
        void TreeToList()
        {
            lvDummy.Items.Clear();
            foreach (TreeNode node in tvDummy.Nodes)
                TreeToList(node);
        }
        void TreeToList(TreeNode Node)
        {
            lvDummy.Items.Add(new ListViewItem(new string[] { Node.Text, Node.FullPath.Count(f => f == '\\').ToString() }));

            foreach(TreeNode node in Node.Nodes)
            {
                TreeToList(node);
            }
        }

        private void btnAddRoot_Click(object sender, EventArgs e)
        {
            tvDummy.Nodes.Add(random.Next().ToString());
            TreeToList();
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            if(tvDummy.SelectedNode == null)
            {
                MessageBox.Show("선택된 노드가 없습니다.","TreeView Test",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            tvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
            tvDummy.SelectedNode.Expand();
            TreeToList();
        }
        #endregion

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() != DialogResult.Cancel)
            {
                textLog.AppendText($"{colorDialog.Color}색을 선택했습니다.\r\n");
                Form frm = new Form();
                frm.Width = 300;
                frm.Height = 300;
                frm.BackColor = colorDialog.Color;
                frm.ShowDialog();
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("선택경로 : " + folderBrowserDialog.SelectedPath);
            }
        }

        private void btnMouseEvent_Click(object sender, EventArgs e)
        {

        }
    }
}
