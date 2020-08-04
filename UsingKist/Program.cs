﻿using System;
using System.Collections;
using System.Net.Http.Headers;
using System.Runtime.ExceptionServices;

namespace UsingList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            for(int i = 0; i <5; i++)
                list.Add(i);

            foreach (object obj in list)
                Console.Write($"{obj} ");
            Console.WriteLine();

            list.RemoveAt(2);

            foreach (object obj in list)
                Console.Write($"{obj} ");
            Console.WriteLine();

            list.Insert(2, 2);

            foreach (object obj in list)
                Console.Write($"{obj} ");
            Console.WriteLine();

            list.Add("abc");
            list.Add("def");

            for (int i = 0; i < list.Count; i++)
                Console.Write($"{list[i]} ");
            Console.WriteLine();
        }
    }
}
