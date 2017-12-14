using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application CloneablePoint to examine ICloneable.
//c Update a method Main() by shallow copying instance p1 to p2 and I try to change the value of p2.X to 0 and it will also change the value of p1.X to 0 because p2 is shallow copied.

namespace CloneablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Cloning *****\n");
            // Two references to same object!
            Point p1 = new Point(50, 50);
            Point p2 = p1;
            p2.X = 0;
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.ReadLine();
        }
    }
}
