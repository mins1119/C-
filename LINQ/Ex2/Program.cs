using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Market
    {
        public string Name { get; set; }
        public string[] Items { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Market> markets = new List<Market>
            {
                new Market{Name="Alice's",Items =new string[]{"rabbit","hatter","flower"}},
                new Market{Name="Belle's",Items =new string[]{"rose","beast","cup","flower"}},
                new Market{Name="Jasmin's",Items =new string[]{"carpet","tiger","lamp"}},
            };
            Console.WriteLine("-----All-----");
            IEnumerable<string> all_names = from market in markets
                                        where market.Items.All(item => item.Length == 6)
                                        select market.Name;
            foreach (string name in all_names)
            {
                Console.WriteLine($"{name} market");
            }

            Console.WriteLine("-----Any-----");
            IEnumerable<string> any_names = from market in markets
                                            where market.Items.Any(item => item.StartsWith("c"))
                                            select market.Name;
            foreach(string name in any_names)
            {
                Console.WriteLine($"{name} market");
            }
            Console.WriteLine("-----Contains-----");
            IEnumerable<string> con_names = from market in markets
                                            where market.Items.Contains("flower")
                                            select market.Name;
            foreach(string name in con_names)
            {
                Console.WriteLine($"{name} market");
            }
        }
    }
}
