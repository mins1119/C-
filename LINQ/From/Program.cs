using System;
using System.Linq;

namespace From
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = from n in numbers
                         where n % 2 == 0
                         orderby n
                         select n;
            foreach (int n in result)
                Console.WriteLine($"짝수:{n}");
        }
    }
}
