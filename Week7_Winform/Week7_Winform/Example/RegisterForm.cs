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
    }
}
