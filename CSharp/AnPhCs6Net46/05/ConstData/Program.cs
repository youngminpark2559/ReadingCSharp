using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application ConstData.
//c Add a class MyMathClass which contains const double data type PI field which is assigned by 3.14 by initialization field on declaration syntaxt. In Main(), I try to manipulate PI but it causes compile time error because const is never changed after it is assigned.

namespace ConstData
{
    class MyMathClass
    {
        public const double PI = 3.14;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Const *****\n");
            Console.WriteLine("The value of PI is: {0}", MyMathClass.PI);
            // Error! Can't change a constant!
            // MyMathClass.PI = 3.1444;

            Console.ReadLine();
        }
    }
}
