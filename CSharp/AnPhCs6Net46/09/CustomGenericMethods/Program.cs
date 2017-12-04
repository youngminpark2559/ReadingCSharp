﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console applicatioin CustomGenericMethods.
//c Add Swap().
//c Add Swap() which is defferent Swap(ref int a, ref int b). This method swaps Person objects incoming to this method.
//c Add a class Person.
//c Add DisplayBaseClass() and update Main() to invoke DisplayBaseClass().

namespace CustomGenericMethods
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Custom Generic Methods *****\n");

            // Swap 2 ints.
            int a = 10, b = 90;
            Console.WriteLine("Before swap: {0}, {1}", a, b);
            Swap<int>(ref a, ref b);
            Console.WriteLine("After swap: {0}, {1}", a, b);
            Console.WriteLine();

            // Swap 2 strings.
            string s1 = "Hello", s2 = "There";
            Console.WriteLine("Before swap: {0} {1}!", s1, s2);
            Swap<string>(ref s1, ref s2);
            Console.WriteLine("After swap: {0} {1}!", s1, s2);

            // Compiler will infer System.Boolean.
            bool b1 = true, b2 = false;
            Console.WriteLine("Before swap: {0}, {1}", b1, b2);
            Swap(ref b1, ref b2);
            Console.WriteLine("After swap: {0}, {1}", b1, b2);

            // Must supply type parameter if
            // the method does not take params.
            DisplayBaseClass<int>();
            DisplayBaseClass<string>();

            // Compiler error! No params? Must supply placeholder!
            // DisplayBaseClass();

            Console.ReadLine();
        }

        // Swap two integers.
        static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        // Swap two Person objects.
        static void Swap(ref Person a, ref Person b)
        {
            Person temp;
            temp = a;
            a = b;
            b = temp;
        }

        // This method will swap any two items.
        // as specified by the type parameter <T>.
        static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine("You sent the Swap() method a {0}",
              typeof(T));
            T temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void DisplayBaseClass<T>()
        {
            // BaseType is a method used in reflection,
            // which will be examined in Chapter 15
            Console.WriteLine("Base class of {0} is: {1}.",
              typeof(T), typeof(T).BaseType);
        }
    }
}
