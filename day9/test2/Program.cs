using System;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameCard = new { Name = "Alice", Age = 17 };
            Console.WriteLine("이름 : {0}, 나이 : {1}",nameCard.Name, nameCard.Age);

            var Complex = new {Real = 3, Imaginary = -12 };
            Console.WriteLine("Real : {0}, Imaginary : {1}", Complex.Real, Complex.Imaginary);
        }
    }
}
