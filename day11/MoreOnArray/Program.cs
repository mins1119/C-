using System;
using System.Net.Sockets;

namespace MoreOnArray
{
    class Program
    {
        private static bool CheckPassed(int score)
        {
            if (score > 60)
                return true;
            else
                return false;
        }
        private static void Print(int value)
        {
            Console.Write($"{value} ");
        }
        static void Main(string[] args)
        {
            int[] scores = new int[] { 61, 75, 43, 69, 99 };
            foreach (int score in scores)
                Console.Write($"{score} ");
            Console.WriteLine();


            Array.Sort(scores);
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            Console.WriteLine($"Number of dimension : {scores.Rank}");

            Console.WriteLine("Binary Search : 69 is at {0}",Array.BinarySearch<int>(scores,75));
            Console.WriteLine("Linear Search : 69 is at {0}", Array.IndexOf(scores, 69));

            Console.WriteLine("Everyone passed ? :{0}",Array.TrueForAll<int>(scores, CheckPassed));

            int index = Array.FindIndex<int>(scores, delegate (int score)
            {
                if (score < 60)
                    return true;
                else
                    return false;
            });

            scores[index] = 61;

            Console.WriteLine("Everyone passed ? : {0}", Array.TrueForAll<int>(scores, CheckPassed));

            Console.WriteLine($"Old Length of scores : {scores.GetLength(0)}");

            Array.Resize<int>(ref scores, 10);

            Console.WriteLine($"New length of scores : {scores.GetLength(0)}");

            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            Array.Clear(scores, 3, 7);

            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();
        }
    }
}
