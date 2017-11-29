using System;

//c I can use 3 class types declared in the same namespace MyShapes but declared in 3 different cs files.
//c I can use 3 class types without using using keyword to reference the namespace. Instead, to use class types, I can use fully qualified name of the class like <namespace name><class name>.

namespace CustomNamespaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyShapes.Hexagon h = new MyShapes.Hexagon();
            MyShapes.Circle c = new MyShapes.Circle();
            MyShapes.Square s = new MyShapes.Square();
        }
    }
}