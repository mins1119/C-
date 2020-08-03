using System;

namespace test1
{
    class NameCard
    {
        private int age;
        private string name;

        public int Age
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NameCard MyCard = new NameCard();
            MyCard.Name = "Alice";
            MyCard.Age = 15;

            Console.WriteLine($"이름 : {MyCard.Name}");
            Console.WriteLine($"나이 : {MyCard.Age}");
        }
    }
}
