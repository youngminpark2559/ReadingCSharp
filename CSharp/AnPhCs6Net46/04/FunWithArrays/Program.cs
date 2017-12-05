using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application FunWithArrays.
//c Add SimpleArrays(). In this method, I create 3 length int array and 100 length string array.
//c Update SimpleArrays(). I create 3 length int array and put the values into the array. And I print all value from myInts array source by using foreach looping.

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
    }
}
