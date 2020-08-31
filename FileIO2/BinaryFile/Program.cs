using System;
using System.IO;

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
            bw.Write("안녕하세요");
            bw.Write(uint.MaxValue);
            bw.Write("HelloWorld");
            bw.Write(double.MaxValue);
            bw.Write("");

            bw.Close();

            BinaryReader br = new BinaryReader(new FileStream("a.dat", FileMode.Open));
            Console.WriteLine($"{br.ReadString()}");   
            Console.WriteLine($"{br.ReadDouble()}");
            Console.WriteLine($"{br.ReadInt32()}");
            Console.WriteLine($"{br.ReadInt32()}");
            Console.WriteLine($"{br.ReadInt32()}");            
        }
    }
}
