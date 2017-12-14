using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application CloneablePoint to examine ICloneable.
//c Update a method Main() by shallow copying instance p1 to p2 and I try to change the value of p2.X to 0 and it will also change the value of p1.X to 0 because p2 is shallow copied.
//c Update a method Main() by deep copying by using Clone() which I implemented in Point(class) type.
//c Update a method Main(). I instantiate instance p3 with passing 2 value type, 1 reference type arguments. When I invoke Clone() on p3, 1 reference type data is copied to p4 by a shallow copy because of default characteristic of MemberwiseClone().
namespace CloneablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Cloning *****\n");
            Console.WriteLine("Cloned p3 and stored new Point in p4");
            Point p3 = new Point(100, 100, "Jane");
            Point p4 = (Point)p3.Clone();

            Console.WriteLine("Before modification:");
            Console.WriteLine("p3: {0}", p3);
            Console.WriteLine("p4: {0}", p4);
            p4.desc.PetName = "My new Point";
            p4.X = 9;

            Console.WriteLine("\nChanged p4.desc.petName and p4.X");
            Console.WriteLine("After modification:");
            Console.WriteLine("p3: {0}", p3);
            Console.WriteLine("p4: {0}", p4);
            Console.ReadLine();
        }
    }
}
