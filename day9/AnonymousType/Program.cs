using System;

namespace AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new { Name = "Alice", Age = "9" };
            Console.WriteLine($"Name : {a.Name} , Age : {a.Age}");

            var b = new { Subject = "math", Scores = new int[] { 90, 20, 70, 40 } };
            Console.Write($"Subject : {b.Subject},Scores : ");
            foreach (var score in b.Scores)
                Console.Write($"{score} ");

            Console.WriteLine();
        }
    }
}
