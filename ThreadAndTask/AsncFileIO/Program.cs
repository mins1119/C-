﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AsyncFileIO
{
    class Program
    {
        static async Task<long> CopyAsync(string fromPath, string toPath)
        {
            using(
                var fromStream = new FileStream(fromPath,FileMode.Open))
            {
                long totalCopied = 0;
                using (
                    var toStream = new FileStream(toPath,FileMode.Create))
                {
                    byte[] buffer = new byte[1024];
                    int nRead = 0;
                    while((nRead = await fromStream.ReadAsync(buffer, 0, buffer.Length)) !=0)
                    {
                        await toStream.WriteAsync(buffer, 0, nRead);
                        totalCopied += nRead;
                    }
                }
                return totalCopied;
            }
        }
        static async void DoCopy(string FromPath, string ToPath)
        {
            long totalCopied = await CopyAsync(FromPath, ToPath);
            Console.WriteLine($"Copied Total {totalCopied} bytes.");
        }
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Usage : AsyncFileIO <Source> <Destination>");
                return;
            }
            DoCopy(args[0], args[1]);
            Console.ReadLine();
        }
    }
}
