using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application TypeConversions to examine narrowing and widening data type conversions.

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with type conversions *****");

            // Add two shorts and print the result.
            short numb1 = 9, numb2 = 10;
            Console.WriteLine("{0} + {1} = {2}",
              numb1, numb2, Add(numb1, numb2));
            Console.ReadLine();
        }
        static int Add(int x, int y)
        {
            return x + y;
        }

    }
}
