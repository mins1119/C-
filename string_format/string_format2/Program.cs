using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_format2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new FileStream("tabledata.txt", FileMode.Open));
            StreamWriter sw = new StreamWriter(new FileStream("table2.txt", FileMode.Create));

            while (sr.EndOfStream == false)
            {
                string txt = sr.ReadLine();

                if (txt.Contains("g_sTableName"))
                {
                    string name = txt.Substring(txt.IndexOf("=") + 1);
                    sw.WriteLine("{" + name + ",");
                    sw.WriteLine("new List<DBFieldInfo>");
                    sw.WriteLine("{");
                }
                try
                {
                    if (txt.Contains("Dbary"))
                    {
                        if (txt[10] == '0')
                        {
                            Console.WriteLine(txt.IndexOf(":"));
                            Console.WriteLine(txt.IndexOf("="));
                            int a = txt.IndexOf(":") - txt.IndexOf("=");
                            sw.Write("new DBFieldInfo(" + txt.Substring(txt.IndexOf("=") + 2, a-2) + ",");

                            sw.WriteLine(txt.Substring(txt.LastIndexOf("=") + 1) + "),");
                        }
                    }
                }
                catch (Exception e) { }
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
