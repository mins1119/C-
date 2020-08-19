using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "Alice", "in", "wonderland" };

            Console.WriteLine("-----selecr-----")
            var s_query = from word in words
                          select word.Substring(0, 1);
            foreach (string s in s_query)
                Console.WriteLine(s);


        }
    }
}
