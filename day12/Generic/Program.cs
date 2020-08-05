using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace Generic
{
    class MyList<T>
    {
        private T[] array;
        public MyList()
        {
            array = new T[3];
        }
        public T this [int index]
        {
            get { return array[index]; }
            set
            {
                if(index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }
                array[index] = value;
            }
        }
        public int Length
        {
            get { return array.Length; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> str_list = new MyList<string>();
            str_list[0] = "a";
            str_list[1] = "b";
            str_list[2] = "c";
            str_list[3] = "d";
            str_list[4] = "e";

            for (int i = 0; i < str_list.Length; i++)
                Console.WriteLine(str_list[i]);
            Console.WriteLine();

            MyList<int> int_list = new MyList<int>();
            int_list[0] = 0;
            int_list[1] = 1;
            int_list[2] = 2;
            int_list[3] = 3;

            for (int i = 0; i < int_list.Length; i++)
                Console.WriteLine(int_list[i]);
        }
    }
}
