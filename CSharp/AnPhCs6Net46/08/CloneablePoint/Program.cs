using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application CloneablePoint to examine ICloneable.
//c Update a method Main() by shallow copying instance p1 to p2 and I try to change the value of p2.X to 0 and it will also change the value of p1.X to 0 because p2 is shallow copied.
//c Update a method Main() by deep copying by using Clone() which I implemented in Point(class) type.

namespace CloneablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Cloning *****\n");
            // Notice Clone() returns a plain object type.
            // You must perform an explicit cast to obtain the derived type.
            Point p3 = new Point(100, 100);
            Point p4 = (Point)p3.Clone();

            // Change p4.X (which will not change p3.X).
            p4.X = 0;

            // Print each object.
            Console.WriteLine(p3);
            Console.WriteLine(p4);
            Console.ReadLine();
        }
    }
}
