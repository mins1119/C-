using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAttribute
{
    class MyClass
    {
        [Obsolete("OldMethod()는 폐기 되었습니다. NewMethod()를 이용하세요ㅡ")]
        public void OldMethod()
        {
            Console.WriteLine("I am Old");
        }
        public void NewMethod()
        {
            Console.WriteLine("I am New");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.OldMethod();
            obj.NewMethod();
        }
    }
}
