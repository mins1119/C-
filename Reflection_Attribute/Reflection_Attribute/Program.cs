using System;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;

namespace Reflection_Attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            Type type = a.GetType();

            //public 인스턴스 필드 조회
            var fields1 = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

            //nonpublic 인스턴스 필드 조회
            var fields2 = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            //public 정적 필드 조회
            var fields3 = type.GetFields(BindingFlags.Public | BindingFlags.Static);

            //nonpublic 정적 필드 조회
            var fields4 = type.GetFields(BindingFlags.NonPublic | BindingFlags.Static);



        }
    }
}
