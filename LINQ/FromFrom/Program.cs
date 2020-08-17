using System;
using System.Linq;
namespace FromFrom
{
    class Class
    {
        public string Name { get; set; }
        public int[] Score { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class[] arrClass =
            {
                new Class(){Name="연두반",Score = new int[]{99,32,75,85}},
                new Class(){Name="분홍반",Score = new int[]{23,87,34}},
                new Class(){Name="개나리반",Score = new int[]{100,77,75,89}},
                new Class(){Name="햇님반",Score = new int[]{12,54,98,99,100}},
                new Class(){Name="파랑반",Score = new int[]{77,78,79,77}}
            };
            var classes = from c in arrClass
                          from s in c.Score
                          where s < 60
                          orderby s
                          select new { c.Name, Lowest = s };
            foreach (var c in classes)
                Console.WriteLine($"낙제 : {c.Name}({c.Lowest})");
        }
    }
}
