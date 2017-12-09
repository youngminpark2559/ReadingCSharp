using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add an abstract class Shapes which contains one virtual method.
//c Add 2 classes Circle and Hexagon which are derived from Shape base class. But Circle class is not overriding Draw() and Hexagon is overriding Draw() by its own logic.

namespace Shapes
{
    // The abstract base class of the hierarchy.
    abstract class Shape
    {
        public Shape(string name = "NoName")
        { PetName = name; }

        public string PetName { get; set; }

        // A single virtual method.
        public virtual void Draw()
        {
            Console.WriteLine("Inside Shape.Draw()");
        }
    }

    // Circle DOES NOT override Draw().
    class Circle : Shape
    {
        public Circle() { }
        public Circle(string name) : base(name) { }
    }

    // Hexagon DOES override Draw().
    class Hexagon : Shape
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", PetName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
