using SimpleMultiThreadApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//c Add a project AddWithThreads to examine the feature of ParameterizedThreadStart delegate.
//c Add a AddParams class which contains data which will be passed into Add() method. Add Add(object data) static method which will be pass into the ParameterizedThreadStart delegate. 
//c Use the WaitOne() method of AutoResetEvent class, to make the thread wait instead of using toggle logic or Thread.Sleep() method.
//c Use the WaitOne() method of AutoResetEvent class, and apply for it in practical.
//c Use a forground and background thread. I make a secondary thread for unit of work and on that thread I invoke PrintNumbers() method. But this thread will be the background thread by the configuration of bgroundThread.IsBackground=ture.

namespace AddWithThreads
{
    class AddParams
    {
        public int a, b;

        public AddParams(int numb1, int numb2)
        {
            a = numb1;
            b = numb2;
        }
    }



    class Program
    {
        static void Add(object data)
        {
            if (data is AddParams)
            {
                Console.WriteLine("ID of thread in Add(): {0}",
                  Thread.CurrentThread.ManagedThreadId);

                AddParams ap = (AddParams)data;
                Console.WriteLine("{0} + {1} is {2}", ap.a, ap.b, ap.a + ap.b);
            }
            // Tell other thread we are done.
            waitHandle.Set();

        }



        private static AutoResetEvent waitHandle = new AutoResetEvent(false);

        static void Main(string[] args)
        {
            Console.WriteLine("***** Background Threads *****\n");
            Printer p = new Printer();
            Thread bgroundThread =
              new Thread(new ThreadStart(p.PrintNumbers));

            // This is now a background thread.
            bgroundThread.IsBackground = true;
            bgroundThread.Start();
        }
    }
}
