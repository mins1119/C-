using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Dns
{
    class Program
    {
        static void Main(string[] args)
        {
            IPHostEntry entry = Dns.GetHostEntry("www.mcirosoft.net");
        }
    }
}
