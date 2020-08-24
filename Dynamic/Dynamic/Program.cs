using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    class MyClass
    {
        public void FuncAAA()
        {
            //do nothing
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dynamic obj = new MyClass();
            obj.FuncAAA();
            obj.FuncBBB();
        }
    }
}
