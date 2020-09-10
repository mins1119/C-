using System;
using System.Diagnostics;
using System.Threading;
namespace AbortInterruptTest
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
                Stopwatch stopwatch = Stopwatch.StartNew();

                Console.WriteLine("try문 Spinwait(1000000)");
                Thread.SpinWait(1000000);   //interrupt

                //Console.WriteLine("try문 Sleep(1000)");
                //Thread.Sleep(1000);

                Console.WriteLine("끝남: {0} ", stopwatch.Elapsed.TotalMilliseconds);
                while (count > 0)
                {
                    Console.WriteLine($"{count--} left");
                    Thread.Sleep(10);
                }
                Console.WriteLine("Count : 0");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("\n\n\n\n" + e);
            }
            catch(ThreadInterruptedException e)
            {
                Console.WriteLine("\n\n\n\n" + e);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Clearing resources...");
            }
        }
    }
    class Program
    {
        private static void printThreadState(System.Threading.ThreadState state)
        {
            Console.WriteLine("스레드 상태 : {0, -16} : {1} \n", state, (int)state);
        }
        static void Main(string[] args)
        {
            SideTask task = new SideTask(100);
            Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
            t1.IsBackground = false;

            Console.WriteLine("Starting Thread...");
            t1.Start();
            printThreadState(t1.ThreadState);

            Thread.Sleep(100);
            printThreadState(t1.ThreadState);

            //Console.WriteLine("Aborting thread...");
            //t1.Abort();
            //printThreadState(t1.ThreadState);


            Console.WriteLine("Interrupting thread...");
            t1.Interrupt();
            printThreadState(t1.ThreadState);

            Console.WriteLine("Waiting until thread stops...");
            printThreadState(t1.ThreadState);
            t1.Join();

            Console.WriteLine("Finished");
        }
    }
}
