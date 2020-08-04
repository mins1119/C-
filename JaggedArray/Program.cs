using System;
using System.Net.Http.Headers;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
            jagged[1] = new int[] { 10, 20 };
            jagged[2] = new int[] { 9, 3, 2, 1 };

            foreach( int[] arr in jagged)
            {
                Console.WriteLine($"Length : {arr.Length}");
                foreach( int e in arr)
                {
                    Console.Write($"{e} ");
                }
                Console.WriteLine("");
            }
        }
    }
}
