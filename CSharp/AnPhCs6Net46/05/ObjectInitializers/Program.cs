using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application ObjectInitializers.
//c Add a class Point.
//c Update a method Main(). I instantiate Point(class) type 3 objects and initialize them all in 3 different ways. 1st: default constructor + set object state data via property by property. 2nd: use a custom constructor with passing values which I want to assign to the object state data(private field.) then inside of this custom constructor, it will assign them via property. 3rd: use object initialize syntax.

namespace ObjectInitializers
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
        }
        public Point() { }

        public void DisplayStats()
        {
            Console.WriteLine("[{0}, {1}]", X, Y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Init Syntax *****\n");

            // Make a Point by setting each property manually.
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();

            // Or make a Point via a custom constructor.
            Point anotherPoint = new Point(20, 20);
            anotherPoint.DisplayStats();

            // Or make a Point using object init syntax.
            Point finalPoint = new Point { X = 30, Y = 30 };
            finalPoint.DisplayStats();
            Console.ReadLine();
        }
    }
}
