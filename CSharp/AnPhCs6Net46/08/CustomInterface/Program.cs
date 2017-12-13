using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Update a method Main(). I instantiate Hexagon instance hex and access to Points property.
//c Update a method Main(). After printing hex.Points, I instantiate Circle instance c and I try to explicit type cast from Circle(class) type to IPointy(interface) type. But This try is not possible because IPointy and Circle have no relationship between them. In other words, they're not type compatable to each other. So this try will trigger the exception with InvalidCastException(class) type object and this instance is caught by catch clause and print the exception object's data as backing field of Message property.
//c Update a method Main(). I use as keyword to check if Hexagon is compatable to IPointy. And if so, I store hex2 reference to IPointy(interface) type local variable itfPt2.
//c Update a method Main(). I use is keyword to check if Hexagon, Circle, Triangle all located in Shape(class) data type array myShapes as an item are compatable to IPointy. If so, it returns true, and I explicit type cast from that type to IPointy(interface) type and access to Points property to get data from backing field of that property.
//c Update a class Program by adding DrawIn3D() taking IDraw3D(interface) type object as an argument.
//c Update a method Main() by using DrawIn3D().
//c Add a method FindFirstPointyShape() taking Shape[](class) type object as an argument. And get the first item compatable to IPointy and explicit type cast that item's type to IPointy and return it to the caller.

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interfaces *****\n");
            // Call Points property defined by IPointy.
            Hexagon hex = new Hexagon();
            Console.WriteLine("Points: {0}", hex.Points);

            // Catch a possible InvalidCastException.
            Circle c = new Circle("Lisa");
            IPointy itfPt = null;
            try
            {
                itfPt = (IPointy)c;
                Console.WriteLine(itfPt.Points);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            // Can we treat hex2 as IPointy?
            Hexagon hex2 = new Hexagon("Peter");
            IPointy itfPt2 = hex2 as IPointy;

            if (itfPt2 != null)
                Console.WriteLine("Points: {0}", itfPt2.Points);
            else
                Console.WriteLine("OOPS! Not pointy...");


            // Make an array of Shapes.
            Shape[] myShapes = { new Hexagon(), new Circle(),
                        new Triangle("Joe"), new Circle("JoJo") };
            for (int i = 0; i < myShapes.Length; i++)
            {
                // Recall the Shape base class defines an abstract Draw()
                // member, so all shapes know how to draw themselves.
                myShapes[i].Draw();
                // Who's pointy?
                if (myShapes[i] is IPointy)
                    Console.WriteLine("-> Points: {0}", ((IPointy)myShapes[i]).Points);
                else
                    Console.WriteLine("-> {0}\'s not pointy!", myShapes[i].PetName);

                // Can I draw you in 3D?
                if (myShapes[i] is IDraw3D)
                    DrawIn3D((IDraw3D)myShapes[i]);
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        // I'll draw anyone supporting IDraw3D.
        static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("-> Drawing IDraw3D compatible type");
            itf3d.Draw3D();
        }

        // This method returns the first object in the
        // array that implements IPointy.
        static IPointy FindFirstPointyShape(Shape[] shapes)
        {
            foreach (Shape s in shapes)
            {
                if (s is IPointy)
                    return s as IPointy;
            }
            return null;
        }
    }
}
