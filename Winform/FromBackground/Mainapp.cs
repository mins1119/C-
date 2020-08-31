using System;
using System.Drawing;
using System.Windows.Forms;

namespace FromBackground
{
    class Mainapp : Form
    {
        Random rand;
        public Mainapp()
        {
            rand = new Random();

            this.MouseWheel += new MouseEventHandler(Mainapp_MouseWheel);
            this.MouseDown += new MouseEventHandler(Mainapp_MouseDown);
        }
        void Mainapp_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Color oldColor = this.BackColor;
                this.BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0,255), rand.Next(0, 255));
            }
            else if(e.Button == MouseButtons.Right)
            {
                if(this.BackgroundImage != null)
                {
                    this.BackgroundImage = null;
                    return;
                }
                string file = "bee.jpg";
                if (System.IO.File.Exists(file) == false)
                    MessageBox.Show("이미지 파일이 없습니다.");
                else
                    this.BackgroundImage = Image.FromFile(file);
            }
        }
        void Mainapp_MouseWheel(object sender, MouseEventArgs e)
        {
            this.Opacity = this.Opacity + (e.Delta > 0 ? 0.1: -0.1);
            Console.WriteLine($"Opacity : {this.Opacity}");
        }

        static void Main(string[] args)
        {
            Application.Run(new Mainapp());
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Mainapp
            // 
            this.ClientSize = new System.Drawing.Size(345, 261);
            this.Name = "Mainapp";
            this.ResumeLayout(false);

        }
    }
}
