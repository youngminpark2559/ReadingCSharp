using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add a structure Point. This struct contains fields, methods.
//c Update Main(). In this method, I use the members of the Point struct.
//c When I create structure type variable, I can simply declare structure type variable. And I can access members through structure variable.
//c I can create structure type variable by using new keyword with invoking default constructor of the structure. With this way, by default constructor, all fields are set to their data type's default values.

namespace FunWithStructures
{
    struct Point
    {
        // Fields of the structure.
        public int X;
        public int Y;
        // Add 1 to the (X, Y) position.
        public void Increment()
        {
            X++; Y++;
        }

        // Subtract 1 from the (X, Y) position.
        public void Decrement()
        {
            X--; Y--;
        }

        // Display the current position.
        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** A First Look at Structures *****\n");

            // Create an initial Point.
            Point myPoint;
            myPoint.X = 349;
            myPoint.Y = 76;
            myPoint.Display();

            // Adjust the X and Y values.
            myPoint.Increment();
            myPoint.Display();


            //// Error! Did not assign Y value.
            //Point p1;
            //p1.X = 10;
            //p1.Display();

            // OK! Both fields assigned before use.
            Point p2;
            p2.X = 10;
            p2.Y = 10;
            p2.Display();


            // Set all fields to default values
            // using the default constructor.
            Point p1 = new Point();

            // Prints X=0,Y=0.
            p1.Display();

            Console.ReadLine();
        }
    }
}
