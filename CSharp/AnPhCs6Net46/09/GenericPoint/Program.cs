using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application GenericPoint.
//c Add a generic structure Point<T>.
//c Instantiate a generic structure Point<T> by specifying types and passing corresponding type values into the constructors.

namespace GenericPoint
{
    // A generic Point structure.
    public struct Point<T>
    {
        // Generic state date.
        private T xPos;
        private T yPos;

        // Generic constructor.
        public Point(T xVal, T yVal)
        {
            xPos = xVal;
            yPos = yVal;
        }

        // Generic properties.
        public T X
        {
            get { return xPos; }
            set { xPos = value; }
        }

        public T Y
        {
            get { return yPos; }
            set { yPos = value; }
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}]", xPos, yPos);
        }

        // Reset fields to the default value of the
        // type parameter.
        public void ResetPoint()
        {
            xPos = default(T);
            yPos = default(T);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Point using ints.
            Point<int> p = new Point<int>(10, 10);

            // Point using double.
            Point<double> p2 = new Point<double>(5.4, 3.3);
        }
    }
}
