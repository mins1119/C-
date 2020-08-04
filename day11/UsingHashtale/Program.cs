using System;
using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace UsingHashtale
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["Alice"] = "Liddel";
            ht["Harry"] = "Potter";
            ht["Optimus"] = "Prime";
            ht["Chris"] = "Pratt";

            Console.WriteLine(ht["Alice"]);
            Console.WriteLine(ht["Harry"]);
            Console.WriteLine(ht["Optimus"]);
            Console.WriteLine(ht["Chris"]);
        }
    }
}
