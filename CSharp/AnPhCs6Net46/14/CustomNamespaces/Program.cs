using MyShapes;

//c I can use 3 class types declared in the same namespace MyShapes but declared in 3 different cs files.

namespace CustomNamespaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hexagon h = new Hexagon();
            Circle c = new Circle();
            Square s = new Square();
        }
    }
}