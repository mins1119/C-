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
            Console.WriteLine(stopwatch.Elapsed.TotalMilliseconds);
        }
    }
}
