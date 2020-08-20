using System;
using System.Collections.Generic;
using System.Globalization;
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

            Console.WriteLine("-----select-----");
            var s_query = from word in words
                          select word.Substring(0, 1);
            foreach (string s in s_query)
                Console.WriteLine(s);

            Console.WriteLine("-----SelectMany-----");
            List<string> phrases = new List<string>() { "Alice in wonderland", "Transformers Dark of the Moon" };

            var m_query = from phrase in phrases
                          from word in phrase.Split(' ')
                          select word;

            foreach (string s in m_query)
                Console.WriteLine(s);


        }
    }
}
