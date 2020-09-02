using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelFuncMenu.Visible = false;
            panelEtcMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelFuncMenu.Visible == true)
                panelFuncMenu.Visible = false;
            if (panelEtcMenu.Visible == true)
                panelEtcMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }
        private void btnFunc_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFuncMenu);
        }

        private void btnBox_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBox());
            textLog.Text += e;
            hideSubMenu();
        }
        private void btnBar_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBar());
            hideSubMenu();
        }
        private void btnEtc_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEtcMenu);
        }
        private void btnPop_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnEtcEtc_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }
        private Form activateForm = null;
        private void openChildForm(Form childForm)
        {
            if (activateForm != null)
                activateForm.Close(); //activateForm 이 null이 아니라면 열 폼이 있는거니까 기존의 폼을 닫는다.
            activateForm = childForm;//그럼 새로 열 activateFrom은 childForm이 되는거겠지
            childForm.TopLevel = false;//Toplevel이면 다루기 어렵다.
            childForm.FormBorderStyle = FormBorderStyle.None; // borderstyle 없음
            childForm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            childForm.BringToFront();
            
            childForm.Show();
        }

        private void ds(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
