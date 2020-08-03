using System;
using System.IO;

namespace Interface
{
    
    class MainApp
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();          
            int i = Convert.ToInt32(num);

            switch (i)
            {
                case int n when (n >= 100):
                    Console.WriteLine($"I am 100 or above: {n}");
                    break;

                case int n when (n < 100 && n >= 50):
                    Console.WriteLine($"I am between 99 and 50: {n}");
                    break;

                case int n when (n < 50):
                    Console.WriteLine($"I am less than 50: {n}");
                    break;
            }
        }
    }
}
