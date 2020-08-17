using System;
using System.Linq;
using System.Collections.Generic;

namespace Sort1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1차 오름차순 정렬
            string[] words = {"Alice","in","the","wonderland" };

            IEnumerable<string> query = from word in words
                                        orderby word.Length
                                        select word;
            foreach (string str in query)
                Console.WriteLine(str);
          //1차 내림차순 정렬
            IEnumerable<string> query_2 = from word in words
                                          orderby word.Substring(0, 1) descending
                                          select word;
            foreach (string str in query_2)
                Console.WriteLine(str);
        }
    }
}
