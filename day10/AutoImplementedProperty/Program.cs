using System;

namespace AutoImplementedProperty
{
    class BirthdayInfo
    {
        public string Name { get; set; } = "UnKnown";
        public DateTime Birthday { get; set; } = new DateTime(1,1,1);
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday}");
            Console.WriteLine($"Age : {birth.Age}");

            birth.Name = "민서";
            birth.Birthday = new DateTime(1000,01,01);

            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday}");
            Console.WriteLine($"Age : {birth.Age}");

        }
    }
}
