using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application FunWithMethods to examine parameter modifiers such none, out, ref, and param.
//c Add a Add() and this method's parameters have no parameter modifiers. So when you invoke this method with passing arguments, the value of arguments is copied and goes into this method.

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        // Arguments are passed by value by default.
        static int Add(int x, int y)
        {
            int ans = x + y;
            // Caller will not see these changes
            // as you are modifying a copy of the
            // original data.
            x = 10000;
            y = 88888;
            return ans;
        }
    }
}
