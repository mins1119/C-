using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectVSSelctMany
{
    class Bouquet
    {
        public List<string> Flowers { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Bouquet> bouquets = new List<Bouquet>()
            {
                new Bouquet{Flowers = new List<string>{ "Daisy","Jasmin","Rose","tulip"} },
                new Bouquet{Flowers = new List<string>{ "iris","lilac","lupin"} },
                new Bouquet{Flowers = new List<string>{"lily","peach","morning glory","orchid"}},
                new Bouquet{Flowers = new List<string>{ "Azalea","Clover","camellia","dandelion"} }
            };
         
            IEnumerable<List<string>> query1 = bouquets.Select(bq => bq.Flowers);

            IEnumerable<string> query2 = bouquets.SelectMany(bq => bq.Flowers);

            Console.WriteLine("Results by using Select() : ");
            foreach(IEnumerable<string> collection in query1)
                foreach(string item in collection)
                    Console.WriteLine(item);

            Console.WriteLine("-----\nResults by using SelectMany() :");
            foreach (string item in query2)
                Console.WriteLine(item);

        }
    }
}
