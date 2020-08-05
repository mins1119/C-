using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

namespace EnumerableGeneric
{
    class MyList<T> : System.Collections.Generic.IEnumerable<T>, IEnumerator<T>
    {
        private T[] array;
        int position = -1;

        public MyList()
        {
            array = new T[3];
        }
        public T this[int index]
        {
            get
            {
                return array[index];
            }
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
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return (array[i]);
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i<array.Length; i++)
            {
                yield return (array[i]);
            }
        }
        public T Current
        {
            get { return array[position]; }
        }
        Object IEnumerator.Current
        {
            get { return array[position]; }
        }
        public bool MoveNext()
        {
            if(position == array.Length - 1)
            {
                Reset();
                return false;
            }
            position++;
            return (position < array.Length);
        }
        public void Reset()
        {
            position = -1;
        }
        public void Dispose()
        {

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

            foreach (string str in str_list)
                Console.WriteLine(str);
            Console.WriteLine();

            MyList<int> int_list = new MyList<int>();
            int_list[0] = 1;
            int_list[1] = 2;
            int_list[2] = 3;
            int_list[3] = 4;
            int_list[4] = 5;

            foreach (int i in int_list)
                Console.WriteLine(i);

        }
    }
}
