using System;
using System.Diagnostics;
using System.Threading;


namespace SpinWait
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Thread.SpinWait(1000000);
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(stopwatch.Elapsed.TotalMilliseconds);
        }
    }
}
