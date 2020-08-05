using System;
using System.Collections.Generic;

namespace UsingDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic["Alice"] = "Liddel";
            dic["Optimus"] = "Prime";
            dic["Rain"] = "Umbrella";

            Console.WriteLine(dic["Alice"]);
            Console.WriteLine(dic["Optimus"]);
            Console.WriteLine(dic["Rain"]);
        }
    }
}
