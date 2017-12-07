using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application SimpleUtilityClass.
//c Add a staic class TimeUtilClass which contains 2 static methods.

namespace SimpleUtilityClass
{
    // Static classes can only
    // contain static members!
    static class TimeUtilClass
    {
        public static void PrintTime()
        { Console.WriteLine(DateTime.Now.ToShortTimeString()); }

        public static void PrintDate()
        { Console.WriteLine(DateTime.Today.ToShortDateString()); }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
