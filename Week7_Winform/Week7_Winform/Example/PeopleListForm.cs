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

namespace Week7_Winform.Example
{
    public partial class PeopleListForm : Form
    {
        public Register Passvalue { get; set; }
        private List<Register> PeopList;
        private string dir = System.IO.Path.Combine(Application.StartupPath, "PeopleList.txt");

        public PeopleListForm()
        {
            InitializeComponent();
            PeopList = new List<Register>();
        }

        private void PeopleListForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(dir))
            {
                LoadData();
            }
            if (Passvalue != null)
            {
                PeopList.Add(Passvalue);
                SaveData();
            }
            
            DisplayData();
        }

        private void SaveData()
        {
            StreamWriter sw = new StreamWriter(new FileStream(dir,FileMode.Append));
            sw.WriteLine(String.Format("{0},{1},{2},{3},{4}\r\n"
                   , Passvalue.Name, Passvalue.Gender, Passvalue.Phone, Passvalue.Birth, Passvalue.ID));
            sw.Close();
            sw.Dispose();
        }

        private void LoadData()
        {
            StreamReader sr = new StreamReader(new FileStream(dir, FileMode.Open));

            while(sr.Peek() >=0)
            {
                string[] arr = sr.ReadLine().Trim().Split(',');
                if(arr[0] != "" && arr[0] != null)
                {
                    Register adata = new Register();
                    adata.Name = arr[0];
                    adata.Gender = arr[1];
                    adata.Phone =arr[2];
                    adata.Birth= arr[3];
                    adata.ID = arr[4];

                    PeopList.Add(adata);
                }
            }
            sr.Close();
        }

        private void DisplayData()
        {
            var query = (from a in PeopList select a).ToList();
            this.dataGridView1.DataSource = query;
        }

    }
}
