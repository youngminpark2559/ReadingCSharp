﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application FunWithArrays.
//c Add SimpleArrays(). In this method, I create 3 length int array and 100 length string array.
//c Update SimpleArrays(). I create 3 length int array and put the values into the array. And I print all value from myInts array source by using foreach looping.
//c Add DeclareImplicitArrays() which uses implicitly typed local variable type by using var keyword for declaration of array.
//c I can't mix data type for each item when especially using var keyword.

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Arrays *****");
            SimpleArrays();
            Console.ReadLine();
        }


        static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation.");
            // Create and fill an array of 3 Integers
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            // Now print each value.
            foreach (int i in myInts)
                Console.WriteLine(i);
            Console.WriteLine();
        }

        static void DeclareImplicitArrays()
        {
            Console.WriteLine("=> Implicit Array Initialization.");

            // a is really int[].
            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a is a: {0}", a.ToString());

            // b is really double[].
            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b is a: {0}", b.ToString());

            // c is really string[].
            var c = new[] { "hello", null, "world" };
            Console.WriteLine("c is a: {0}", c.ToString());

            // Error! Mixed types!
            //var d = new[] { 1, "one", 2, "two", false };

            Console.WriteLine();
        }


    }
}
