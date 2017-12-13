using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Update a method Main(). I instantiate Hexagon instance hex and access to Points property.
//c Update a method Main(). After printing hex.Points, I instantiate Circle instance c and I try to explicit type cast from Circle(class) type to IPointy(interface) type. But This try is not possible because IPointy and Circle have no relationship between them. In other words, they're not type compatable to each other. So this try will trigger the exception with InvalidCastException(class) type object and this instance is caught by catch clause and print the exception object's data as backing field of Message property.

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

            Console.ReadLine();
        }
    }
}
