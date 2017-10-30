using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticField
{
    public class Point { public int X, Y; }

    class Program
    {
        static void Main()
        {
            short a = 1;
            short b = 2;
            int c = (int)(a + b);

            Console.WriteLine(c);

            short x = 1, y = 1;
//          short z = x + y;          // Compile-time error

        }
    }
}
