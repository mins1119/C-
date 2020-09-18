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
            StreamReader sr = new StreamReader(new FileStream("modFunc.txt", FileMode.Open));
            StreamWriter sw = new StreamWriter(new FileStream("modFunc2.txt", FileMode.Create));

            while (sr.EndOfStream == false)
            {
                string txt = sr.ReadLine();
                
                if(txt.StartsWith("Public Sub"))
                { 
                    sw.WriteLine(txt);
                }
                if (txt.StartsWith("g_sTableName"))
                {
                        sw.WriteLine("UpdateTableByTableName(uow," + txt.Substring(txt.IndexOf("=")+2) + ");");
                }
                if (txt.StartsWith("End Sub"))
                {
                    sw.WriteLine("\n\n");
                }
            }
            sr.Close();

            sw.Close();
            
        }
    }
}