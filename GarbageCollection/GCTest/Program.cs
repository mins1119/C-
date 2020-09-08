using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCTest
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = new object();
            Console.WriteLine(GC.GetGeneration(a));


            GC.Collect();
            Console.WriteLine(GC.GetGeneration(a));

            GC.Collect();
            Console.WriteLine(GC.GetGeneration(a));

            GC.Collect();
            Console.WriteLine(GC.GetGeneration(a));

        }
    }
}
