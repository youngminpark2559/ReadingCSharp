using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//c Add a project MultiThreadedPrinting to examine the concurrency occurred when multiple threads attempt to manipulate a shared data.
//c Use lock keyword to achieve the thread safe. All threads complete its task without being interfered by other thread's attempting to the shared data, one by one up to 10th thread.
//c Use Synchronization attribute to make this object instantiated into the thread safe object contextual boundary. So that, all codes in this object are executed thread-safely without any explicit thread-safe code such as lock, monitor, and interlock.

namespace MultiThreadedPrinting
{

    // All methods of Printer are now thread safe!
    [Synchronization]
    public class Printer
    {
        // Lock token.
        private object threadLock = new object();

        public void PrintNumbers()
        {
            // Use the private object lock token.
            lock (threadLock)
            {
                // Display Thread info.
                Console.WriteLine("-> {0} is executing PrintNumbers()",
                  Thread.CurrentThread.Name);
                // Print out numbers.
                Console.Write("Your numbers: ");
                for (int i = 0; i < 10; i++)
                {
                    Random r = new Random();
                    Thread.Sleep(1000 * r.Next(5));
                    Console.Write("{0}, ", i);
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Synchronizing Threads *****\n");

            Printer p = new Printer();

            // Make 10 threads that are all pointing to the same
            // method on the same object.
            Thread[] threads = new Thread[10];
            for (int i = 0; i < 10; i++)
            {
                threads[i] =
                  new Thread(new ThreadStart(p.PrintNumbers));
                threads[i].Name = string.Format("Worker thread #{0}", i);
            }
            // Now start each one.
            foreach (Thread t in threads)
                t.Start();
            Console.ReadLine();
        }


    }
}
