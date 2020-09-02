using System;
using System.IO;

namespace BinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryWriter bw = new BinaryWriter(new FileStream("a.dat", FileMode.Create));
            bw.Write(10);
            bw.Write("Hello");
            bw.Write(int.MaxValue);
            bw.Write("bye!");
            bw.Write(0.1);

            bw.Close();

            BinaryReader br = new BinaryReader(new FileStream("a.dat", FileMode.Open));
            Console.WriteLine($"{br.ReadInt32()}");
            Console.WriteLine($"{br.ReadString()}");
            Console.WriteLine($"{br.ReadInt32()}");
            Console.WriteLine($"{br.ReadInt32()}");
            Console.WriteLine($"{br.ReadDouble()}");


        }
    }
}
