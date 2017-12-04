using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application GenericPoint.
//c Add a generic structure Point<T>.
//c Instantiate a generic structure Point<T> by specifying types and passing corresponding type values into the constructors.
//c Update Main() to use default(T) syntax.
//c Add a generic class BasicMath<T>. I use operators to type parameters and it makes a compile time error.
//c Update a generic class BasicMath<T> by using where keyword. But this is not possible under the current .NET version. Just get the idea from this. And the same functionality here can be implemented by using interface and constraints on it.

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

    // Compiler error! Cannot apply operators to type parameters!
    //public class BasicMath<T>
    //{
    //    public T Add(T arg1, T arg2)
    //    { return arg1 + arg2; }
    //    public T Subtract(T arg1, T arg2)
    //    { return arg1 - arg2; }
    //    public T Multiply(T arg1, T arg2)
    //    { return arg1 * arg2; }
    //    public T Divide(T arg1, T arg2)
    //    { return arg1 / arg2; }
    //}


    //// Illustrative code only!
    //public class BasicMath<T> where T : operator +,  operator -,  operator *, operator / 
    //{
    //    public T Add(T arg1, T arg2)
    //    { return arg1 + arg2; }
    //    public T Subtract(T arg1, T arg2)
    //    { return arg1 - arg2; }
    //    public T Multiply(T arg1, T arg2)
    //    { return arg1 * arg2; }
    //    public T Divide(T arg1, T arg2)
    //    { return arg1 / arg2; }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            // Point using ints.// Point using ints.
            Point<int> p = new Point<int>(10, 10);
            Console.WriteLine("p.ToString()={0}", p.ToString());
            p.ResetPoint();
            Console.WriteLine("p.ToString()={0}", p.ToString());
            Console.WriteLine();

            // Point using double.
            Point<double> p2 = new Point<double>(5.4, 3.3);
            Console.WriteLine("p2.ToString()={0}", p2.ToString());
            p2.ResetPoint();
            Console.WriteLine("p2.ToString()={0}", p2.ToString());
            Console.ReadLine();

        }


    }
}
