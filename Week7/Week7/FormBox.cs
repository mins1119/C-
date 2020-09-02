using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Week7
{
    public partial class FormBox : Form
    {
        public FormBox()
        {
            InitializeComponent();
        }

        private void FormBox_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families;
            foreach (FontFamily font in Fonts)
                cboFont.Items.Add(font.Name);
        }
        void ChangeFont()
        {
            if (cboFont.SelectedIndex < 0)
                return;
            FontStyle style = FontStyle.Regular;

            if (chkBold.Checked)
                style |= FontStyle.Bold;
            if (chkItalic.Checked)
                style |= FontStyle.Italic;
            txtAfterText.Text = txtBeforeText.Text;
            txtAfterText.Font = new Font((string)cboFont.SelectedItem,10,style);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        
        }

        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }
    }
}
