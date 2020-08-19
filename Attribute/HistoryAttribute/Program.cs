using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryAttribute
{
    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true)]
    class History : System.Attribute
    {
        private string programmer;
        public double version;
        public string changes;

        public History(string programmer)
        {
            this.programmer = programmer;
            version = 1.0;
            changes = "First Release";
        }
        public string GetProgrammer()
        {
            return programmer;
        }
    }
    [History("Sean",version =0.1,changes = "2020-05-07 Created class stub")]
    [History("Bob",version =0.2,changes = "2020-08-07 Added Fnnc() Method")]
    class MyClass
    {
        public void Func()
        {
            Console.WriteLine("Func()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(MyClass);
            Attribute[] attributes = Attribute.GetCustomAttributes(type);

            Console.WriteLine("Myclass change History...");

            foreach(Attribute a in attributes)
            {
                History h = a as History;
                if (h != null)
                    Console.WriteLine($"Ver : {h.version}, Programmer : {h.GetProgrammer()}, changes : {h.changes}");
            }
        }
    }
}
