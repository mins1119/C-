using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Distinct-----");
            string[] planets = { "Mercury","Venus","Mars","Pluto","Venus","Earth","Pluto"};

            IEnumerable<string> distinct = from planet in planets.Distinct()
                                        select planet;
            foreach(var str in distinct)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("-----Except-----");
            string[] planets1 = { "Mercury", "Venus", "Earth", "Jupiter" };
            string[] planets2 = { "Mercury", "Earth", "Mars", "Jupiter" };
            IEnumerable<string> except = from planet in planets1.Except(planets2)
                                         select planet;

            foreach(var str in except)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("-----Intersect-----");
            IEnumerable<string> intersect = from planet in planets1.Intersect(planets2)
                                            select planet;
            foreach(var str in intersect)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("-----Union-----");
            IEnumerable<string> union = from planet in planets1.Union(planets2)
                                        select planet;
            foreach(var str in union)
            {
                Console.WriteLine(str);
            }
        }
    }
}
