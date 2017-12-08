using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application ConstData.
//c Add a class MyMathClass which contains const double data type PI field which is assigned by 3.14 by initialization field on declaration syntaxt. In Main(), I try to manipulate PI but it causes compile time error because const is never changed after it is assigned.
//c Add a static method LocalConstStringVariable() in which it declares const string data type local variable fixedStr and assign initial value to it.

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

            LocalConstStringVariable();

            Console.ReadLine();
        }

        static void LocalConstStringVariable()
        {
            // A local constant data point can be directly accessed.
            const string fixedStr = "Fixed string Data";
            Console.WriteLine(fixedStr);

            // Error!
            // fixedStr = "This will not work!";
        }
    }
}
