using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace view_format
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new FileStream("view_trim.txt", FileMode.Open));
            StreamWriter sw = new StreamWriter(new FileStream("view_final.txt", FileMode.Create));

            while (sr.EndOfStream == false)
            {
                string txt = sr.ReadLine();

                if (txt.Contains("g_sTableName"))
                {
                    string name = txt.Substring(txt.IndexOf("=") + 1);
                    sw.WriteLine("{\"" + name + "\",");
                }

                if (txt.Contains("sViewQuery"))
                {
                    while () 
                    { 
                    
                    }
                    if (txt[10] == '0')
                    {
                        Console.WriteLine(txt.IndexOf(":"));
                        Console.WriteLine(txt.IndexOf("="));
                        int a = txt.IndexOf(":") - txt.IndexOf("=");
                        sw.Write("new DBFieldInfo(" + txt.Substring(txt.IndexOf("=") + 2, a - 2) + ",");

                        sw.WriteLine(txt.Substring(txt.LastIndexOf("=") + 1) + "),");
                    }
                }
                if (txt.Contains("Fs_CheckDB Dbary"))
                {
                    sw.WriteLine("}");
                    sw.WriteLine("},");
                }
            }
        }
    }
}
