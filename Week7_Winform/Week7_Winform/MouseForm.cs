using System;
using System.Collections;
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
    public partial class MouseForm : Form
    {
        public MouseForm()
        {
            InitializeComponent();
        }

        private void MouseForm_Load(object sender, EventArgs e)
        {

        }

        private void MouseForm_MouseClick(object sender, MouseEventArgs e)
        {
            MainForm parantForm = (MainForm)Owner;
            parantForm.MouseEventValue = $"{e.X},{e.Y}";
        }
    }
}
