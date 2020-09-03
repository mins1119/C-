using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7_Winform.Example
{
    public partial class RegisterForm : Form
    {
      
        public RegisterForm()
        {
            InitializeComponent();
            RegisterPic.Image = Week7_Winform.Properties.Resources.imageSelect;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
        #region 가입 폼 관련
        private void textPw2_Enter(object sender, EventArgs e)
        {
            if (textPw.Text == string.Empty)
                textPw.Focus();
        }
        private void textPw2_TextChanged(object sender, EventArgs e)
        {
            if (textPw.Text != textPw2.Text)
                errorProvider1.SetError(textPw2, "비밀번호가 같지 않습니다.");
            else
                errorProvider1.Clear();
        }

        private void RegisterPic_Click(object sender, EventArgs e)
        {
            string regi_image = string.Empty;

            OpenFileDialog regi_dialog = new OpenFileDialog();
            regi_dialog.InitialDirectory = @"C:\Users\User\Pictures";

            if(regi_dialog.ShowDialog() ==DialogResult.OK)
            {
                regi_image = regi_dialog.FileName;
            }
            else if(regi_dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            RegisterPic.Image = Bitmap.FromFile(regi_image);
            RegisterPic.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        #endregion

        private void btnRegi_Click(object sender, EventArgs e)
        {
            Register a = new Register();
            PeopleListForm fromList = new PeopleListForm();

            if (textName.Text != string.Empty & textId.Text != string.Empty & textPw.Text != string.Empty) 
            { 
                a.Name = textName.Text.Trim();
                a.Phone = textPhone.Text.Trim();


                a.Birth = $"{dateBirth.Value.Year} 년 {dateBirth.Value.Month}월 {dateBirth.Value.Day}일";
                a.ID = textId.Text.Trim();  
                a.Gender = rbtnFemale.Checked ? "female" : "male";

                fromList.Passvalue = a;
                MessageBox.Show("등록되었습니다.");
                this.Close();
                fromList.ShowDialog();
            }
            else 
            MessageBox.Show("모든 항목을 입력해 주세요.");
        }

    }
}
