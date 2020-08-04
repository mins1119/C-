using System;

namespace DerivedFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 20, 30, 40 };
            Console.WriteLine($"Type of array : {array.GetType()}");
            Console.WriteLine($"Base Type OF array : {array.GetType().BaseType}");
        }
    }
}
