using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application ConstData.
//c Add a class MyMathClass which contains const double data type PI field which is assigned by 3.14 by initialization field on declaration syntaxt. In Main(), I try to manipulate PI but it causes compile time error because const is never changed after it is assigned.
//c Add a static method LocalConstStringVariable() in which it declares const string data type local variable fixedStr and assign initial value to it.
//c Update a class MyMathClass with trying to initialize const by constructor but it causes compile time error. const should be initialized on declaration by initialization field on declaration syntax.
//c Update a class MyMathClass by adding readonly double data type field PI. readonly field can be assigned via the constructor but nowhere else.

namespace ConstData
{
    class MyMathClass
    {
        //public const double PI = 3.14;

        // Read-only fields can be assigned in ctors,
        // but nowhere else.
        public readonly double PI;

        public MyMathClass()
        {
            PI = 3.14;
        }
    }

    //class MyMathClass
    //{
    //    // Try to set PI in ctor?
    //    public const double PI;

    //    public MyMathClass()
    //    {
    //        // Not possible- must assign at time of declaration.
    //        PI = 3.14;
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Const *****\n");
            //Console.WriteLine("The value of PI is: {0}", MyMathClass.PI);
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
