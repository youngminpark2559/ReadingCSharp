using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application ObjectInitializers.
//c Add a class Point.
//c Update a method Main(). I instantiate Point(class) type 3 objects and initialize them all in 3 different ways. 1st: default constructor + set object state data via property by property. 2nd: use a custom constructor with passing values which I want to assign to the object state data(private field.) then inside of this custom constructor, it will assign them via property. 3rd: use object initialize syntax.
//c Add a class Rectangle.
namespace ObjectInitializers
{
    enum PointColor
    { LightBlue, BloodRed, Gold }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointColor Color { get; set; }

        public Point(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
            Color = PointColor.Gold;
        }

        public Point(PointColor ptColor)
        {
            Color = ptColor;
        }

        public Point()
          : this(PointColor.BloodRed)
        { }

        public void DisplayStats()
        {
            Console.WriteLine("[{0}, {1}]", X, Y);
            Console.WriteLine("Point is {0}", Color);
        }
    }

    class Rectangle
    {
        private Point topLeft = new Point();
        private Point bottomRight = new Point();

        public Point TopLeft
        {
            get { return topLeft; }
            set { topLeft = value; }
        }
        public Point BottomRight
        {
            get { return bottomRight; }
            set { bottomRight = value; }
        }

        public void DisplayStats()
        {
            Console.WriteLine("[TopLeft: {0}, {1}, {2} BottomRight: {3}, {4}, {5}]",
              topLeft.X, topLeft.Y, topLeft.Color,
              bottomRight.X, bottomRight.Y, bottomRight.Color);
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
            

            // Calling a more interesting custom constructor with init syntax.
            Point goldPoint = new Point(PointColor.Gold) { X = 90, Y = 20 };
            goldPoint.DisplayStats();

            Console.ReadLine();
        }
    }
}
