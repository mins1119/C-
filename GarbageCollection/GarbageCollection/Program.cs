﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pg = new Program();
            Console.WriteLine(GC.GetGeneration(pg));
        }
    }
}
