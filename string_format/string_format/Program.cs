using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_format
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new FileStream("tabledata2.txt", FileMode.Open));
            StreamWriter sw = new StreamWriter(new FileStream("table2.txt", FileMode.Create));

            while (sr.EndOfStream == false)
            {
                string txt = sr.ReadLine();
                
                if(txt.Contains("g_sTableName"))
                {
                    Console.WriteLine(txt);
                    string name = txt.Substring(txt.IndexOf("=") + 1);
                    sw.WriteLine("{"+ name + ",");
                    sw.WriteLine("new List<DBFieldInfo>");
                    sw.WriteLine("{");
                }
                if (txt.Contains("Dbary"))
                {
                    if (txt[10] == '0') {
                        sw.Write("new DBFieldInfo(" + txt.Substring(txt.IndexOf("=")+2) + ",");
                    }
                    if (txt[10] == '1')
                    {
                        sw.WriteLine(txt.Substring(txt.IndexOf("=")+1) + "),");
                    }
                }

                if (txt.Contains("Fs_CheckDB Dbary"))
                {
                    sw.WriteLine("}");
                    sw.WriteLine("},");
                }
            }
            sr.Close();

            sw.Close();
            
        }
    }
}