using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace UsingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string srcFile = args[0];

            Action<object> FilecopyAction = (object state) =>
            {
                String[] paths = (String[])state;
                File.Copy(paths[0], paths[1]);

                Console.WriteLine($"TaskID : {Task.CurrentId}, ThreadID : {Thread.CurrentThread}, {paths[0]} was copied to {paths[1]}");
            };

            Task t1 = new Task(FilecopyAction, new String[] { srcFile, srcFile + ".copy1" });

            Task t2 = Task.Run(() =>
            {
                FilecopyAction(new String[] { srcFile, srcFile + ".copt2" });
            });
            t1.Start();

            Task t3 = new Task(
                FilecopyAction, new String[] { srcFile, srcFile + ".copy3" });

            t3.RunSynchronously();

            t1.Wait();
            t2.Wait();
            t3.Wait();

        }
    }
}
