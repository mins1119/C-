using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trim
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new FileStream("uf.txt", FileMode.Open));
            StreamWriter sw = new StreamWriter(new FileStream("aaaa.txt", FileMode.Create));


            List<string> list = new List<string>();
            List<string> list2 = new List<string>();
            while (sr.EndOfStream == false)
            {
                string txt = sr.ReadLine();
                if (txt.StartsWith("{ \""))
                    list.Add(txt);
            }

            list2 = list.Distinct().ToList();

            foreach (string Key in list)
            {
                Console.WriteLine(Key);
            }


            Console.WriteLine("**********************************************");

            foreach (string Key in list2)
            {
                Console.WriteLine(Key);
            }

            sr.Close();

            sw.Close();
        }
    }
}
