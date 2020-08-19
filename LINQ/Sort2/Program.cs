using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Sort2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "the", "quick","brown", "fox", "jumps" };
            IEnumerable<string> query = from word in words
                                        orderby word.Length, word.Substring(0, 1)
                                        select word;
            foreach (string str in query)
                Console.WriteLine(str);

            IEnumerable<string> query2 = from word in words
                                         orderby word.Length, word.Substring(0, 1) descending
                                         select word;
            foreach (string str in query2)
                Console.WriteLine(str);
        }
    }
}
