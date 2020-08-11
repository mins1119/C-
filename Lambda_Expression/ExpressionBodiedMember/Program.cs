using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExpressionBodiedMember
{
    class FriendList
    {
        private List<string> list = new List<string>();

        public void Add(string name) => list.Add(name);
        public void Remove(string name) => list.Remove(name);
        public void PrintAll()
        {
            foreach (var s in list)
                Console.WriteLine(s);
        }
        public FriendList() => Console.WriteLine("FriendList()");
        ~FriendList() => Console.WriteLine("~FriendList()");

        public int Capacity
        {
            get => list.Capacity;
            set => list.Capacity = value;
        }
        public string this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FriendList obj = new FriendList();
            obj.Add("Alice");
            obj.Add("Optimus");
            obj.Add("Bumblebee");
            obj.Add("Thundercracker");
            obj.Remove("Thundercracker");
            obj.PrintAll();

            Console.WriteLine($"{obj.Capacity}");
            obj.Capacity = 10;
            Console.WriteLine($"{obj.Capacity}");

            Console.WriteLine($"{obj[0]}");
            obj[0] = "Jazz";
            obj.PrintAll();
        }
    }
}
