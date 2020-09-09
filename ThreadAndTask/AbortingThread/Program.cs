using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AbortingThread
{
    class SideTask
    {
        int count;
        public SideTask(int count)
        {
            this.count = count;
        }
        public void KeepAlive()
        {
            try
            {
                //Thread.SpinWait(1000000);
                Thread.Sleep(1000);
                while (count >0)
                {
                    Console.WriteLine($"{count--} left");
                    Thread.Sleep(10);
                }
                Console.WriteLine("Count : 0");
            }
            catch(ThreadAbortException e)
            {
                Console.WriteLine("\n\n\n\n" + e);
            }
            finally
            {
                Console.WriteLine("Clearing resources...");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            SideTask task = new SideTask(100);
            Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
            t1.IsBackground = false;

            Console.WriteLine("Start() 호출 : {0}", stopwatch.Elapsed.TotalMilliseconds);
            Console.WriteLine("Starting Thread...");
            t1.Start();

            Console.WriteLine("sleep() 호출 : {0}",stopwatch.Elapsed.TotalMilliseconds);
            Thread.Sleep(100);

            Console.WriteLine("Aborting thread...");
            Console.WriteLine("Abort() 호출 : {0} ",stopwatch.Elapsed.TotalMilliseconds);
            t1.Abort();

            Console.WriteLine("Waiting until thresd stops...");
            t1.Join();

            Console.WriteLine("Finished");
            Console.WriteLine("끝남: {0} ", stopwatch.Elapsed.TotalMilliseconds);
        }
    }
}
