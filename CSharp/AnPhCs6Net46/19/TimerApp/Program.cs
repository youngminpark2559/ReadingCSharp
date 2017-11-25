using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add a project TimerApp to examine the delegate TimerCallback.

namespace TimerApp
{
    class Program
    {
        static void PrintTime(object state)
        {
            Console.WriteLine("Time is: {0}",
              DateTime.Now.ToLongTimeString());
        }

        static void Main(string[] args)
        {
        }
    }
}
