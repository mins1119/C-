using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace day1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] num = { 1, 2, 3 };
                Console.WriteLine(num[10]);
            }
            catch(Exception e)
            {
                Console.WriteLine("Something wrong");
            }
            finally
            {
                Console.WriteLine("try...catch is finished");
            }
        }
    }
}
