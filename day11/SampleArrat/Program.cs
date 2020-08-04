using System;
using System.Net.Sockets;

namespace SampleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            scores[0] = 30;
            scores[3] = 40;
            scores[4] = 100;

            foreach (int score in scores)
                Console.WriteLine(score);
            int sum = 0;
            foreach (int score in scores)
                sum += score;

            int average = sum / scores.Length;

            Console.WriteLine($"Average Score: {average}");
        }
    }
}
