using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new FileStream("test.txt", FileMode.Open));
            string str = sr.ReadToEnd().Replace(" ","");
            //Console.Write(str);

            BinaryWriter bw = new BinaryWriter(new FileStream("a.dat", FileMode.Create));
            //bw.Write(str);
            bw.Write(int.MaxValue);
            bw.Write("Alice in Wonderland");
            bw.Write(uint.MaxValue);
            bw.Write("Transformers");
            bw.Write(double.MaxValue);
            bw.Write("");

            bw.Close();

            BinaryReader br = new BinaryReader(new FileStream("a.dat", FileMode.Open));
            //Console.WriteLine($"{br.ReadString()}");   
            Console.WriteLine($"{br.ReadDouble()}");
            Console.WriteLine($"{br.ReadInt32()}");
            Console.WriteLine($"{br.ReadInt32()}");
            Console.WriteLine($"{br.ReadInt32()}");            
        }
    }
}
