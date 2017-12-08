using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application ObjectInitializers.
//c Add a class Point.

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
        }
    }
}
