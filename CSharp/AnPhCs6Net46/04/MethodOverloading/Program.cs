using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application MethodOverloading.
//c Add 3 overloaded Add().

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        // Overloaded Add() method.
        static int Add(int x, int y)
        { return x + y; }

        static double Add(double x, double y)
        { return x + y; }

        static long Add(long x, long y)
        { return x + y; }
    }
}
