using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Import the static members of Console and DateTime.
using static System.Console;
using static System.DateTime;

//c Create a console application SimpleUtilityClass.
//c Add a staic class TimeUtilClass which contains 2 static methods.
//c Update a method Main(). Within this, I invoke static methods by accessing directly them via TimeUtilClass. And if I create an object of this staic class, I get the compile-time error.

namespace SimpleUtilityClass
{
    // Static classes can only
    // contain static members!
    static class TimeUtilClass
    {
        public static void PrintTime()
        { WriteLine(Now.ToShortTimeString()); }

        public static void PrintDate()
        { WriteLine(Today.ToShortDateString()); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Static Classes *****\n");

            // This is just fine.
            TimeUtilClass.PrintDate();
            TimeUtilClass.PrintTime();

            // Compiler error! Can't create instance of static classes!
            //TimeUtilClass u = new TimeUtilClass();

            Console.ReadLine();
        }
    }
}
