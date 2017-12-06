using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add ValueTypeAssignment() which declares 2 Point(struct) type local variable on the stack and I assign created Point(struct) type into p1. And I assign p1 to p2 variable. Now, I have 2 Point(struct) type local variables on the stack which stores same Point(struct) type holding 10, 10 to x, y fields.
//c Add a class PointRef to compare the nature characteristics between value type and reference type.
//c Add ReferenceTypeAssignment() which plays a same role with ValueTypeAssignment() except I'm dealing with data by reference type. With this, I have 2 PointRef(class) type local variables on the stack which store the reference address of the PointRef(class) type instance on the managed heap. Since 2 PointRef(class) type local variables on the stack are storing same reference address for the PointRef(class) type instance, changing instance can be seen by both variables.
//c Add a class ShapeInfo and a struct Rectangle. Now, a Rectangle(struct) type is containing ShapeInfo(class) type field. We can examine a shallow copy by this codes.
//c Add ValueTypeContainingRefType(). I create one Rectangle(struct) type instance and it's containing ShapeInfo(class) type filed, by invoking the custom constructor of Rectangle structure. Inside of this structure instance, I have a refernce address for the ShapeInfo(class) type instance, in the rectInfo field. And I copy r1 to r2. r2 is seeing same instance of what r1 is seeing.

namespace ValueAndReferenceTypes
{
    struct Point
    {
        // Fields of the structure.
        public int X;
        public int Y;

        // A custom constructor.
        public Point(int XPos, int YPos)
        {
            X = XPos;
            Y = YPos;
        }

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

    class PointRef
    {
        // Fields of the structure.
        public int X;
        public int Y;

        // A custom constructor.
        public PointRef(int XPos, int YPos)
        {
            X = XPos;
            Y = YPos;
        }

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

    class ShapeInfo
    {
        public string infoString;
        public ShapeInfo(string info)
        {
            infoString = info;
        }
    }

    struct Rectangle
    {
        // The Rectangle structure contains a reference type member.
        public ShapeInfo rectInfo;

        public int rectTop, rectLeft, rectBottom, rectRight;

        public Rectangle(string info, int top, int left, int bottom, int right)
        {
            rectInfo = new ShapeInfo(info);
            rectTop = top; rectBottom = bottom;
            rectLeft = left; rectRight = right;
        }

        public void Display()
        {
            Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, " +
              "Left = {3}, Right = {4}",
              rectInfo.infoString, rectTop, rectBottom, rectLeft, rectRight);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ValueTypeAssignment();
        }

        // Assigning two intrinsic value types results in
        // two independent variables on the stack.
        static void ValueTypeAssignment()
        {
            Console.WriteLine("Assigning value types\n");

            Point p1 = new Point(10, 10);
            Point p2 = p1;

            // Print both points.
            p1.Display();
            p2.Display();

            // Change p1.X and print again. p2.X is not changed.
            p1.X = 100;
            Console.WriteLine("\n=> Changed p1.X\n");
            p1.Display();
            p2.Display();
        }


        static void ReferenceTypeAssignment()
        {
            Console.WriteLine("Assigning reference types\n");
            PointRef p1 = new PointRef(10, 10);
            PointRef p2 = p1;

            // Print both point refs.
            p1.Display();
            p2.Display();

            // Change p1.X and print again.
            p1.X = 100;
            Console.WriteLine("\n=> Changed p1.X\n");
            p1.Display();
            p2.Display();
        }

        static void ValueTypeContainingRefType()
        {
            // Create the first Rectangle.
            Console.WriteLine("-> Creating r1");
            Rectangle r1 = new Rectangle("First Rect", 10, 10, 50, 50);

            // Now assign a new Rectangle to r1.
            Console.WriteLine("-> Assigning r2 to r1");
            Rectangle r2 = r1;

            // Change some values of r2.
            Console.WriteLine("-> Changing values of r2");
            r2.rectInfo.infoString = "This is new info!";
            r2.rectBottom = 4444;

            // Print values of both rectangles.
            r1.Display();
            r2.Display();
        }
    }
}
