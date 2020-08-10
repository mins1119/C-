using System;
using System.ComponentModel;

namespace AnonymousMethod
{
    delegate int Compare(int a, int b);
    class Program
    {
        static void BubbleSort(int[] DataSet, Compare Comparer)
        {
            int i = 0;
            int j = 0;
            int temp = 0;
            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 4, 6, 2, 6, 8, 2, 45 };
            Console.WriteLine("Sorting ascending..");
            BubbleSort(array, delegate (int a, int b)
            {
                if (a > b)
                    return 1;
                else if (a == b)
                    return 0;
                else
                    return -1;
            });
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"{array[i]}");
            
            int[] array2 = { 4, 6, 2, 6, 8, 2, 45 };
            Console.WriteLine("Sorting descending..");
            BubbleSort(array2, delegate (int a, int b)
            {
                if (a < b)
                    return 1;
                else if (a == b)
                    return 0;
                else
                    return -1;
            });
            for (int i = 0; i < array2.Length; i++)
                Console.WriteLine($"{array2[i]}");

        }
    }
}
