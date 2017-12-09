using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add an abstract class Shapes which contains one virtual method.
//c Add 2 classes Circle and Hexagon which are derived from Shape base class. But Circle class is not overriding Draw() and Hexagon is overriding Draw() by its own logic.
//c Update a class Shape to set Draw() from virtual method to abstract method. Now, all derived class must override Draw() in their class.

namespace Shapes
{
    // The abstract base class of the hierarchy.
    abstract class Shape
    {
        public Shape(string name = "NoName")
        { PetName = name; }

        public string PetName { get; set; }

        //// A single virtual method.
        //public virtual void Draw()
        //{
        //    Console.WriteLine("Inside Shape.Draw()");
        //}

        // Force all child classes to define how to be rendered.
        public abstract void Draw();
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
            Console.WriteLine("***** Fun with Polymorphism *****\n");

            Hexagon hex = new Hexagon("Beth");
            hex.Draw();
            Circle cir = new Circle("Cindy");
            // Calls base class implementation!
            cir.Draw();
            Console.ReadLine();
        }
    }
}
