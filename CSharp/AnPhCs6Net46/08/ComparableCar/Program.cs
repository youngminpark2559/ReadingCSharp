using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c I try to invoke Sort() with passing Car[](class) type instance myAutos. But the array of the custom(class) type Car doesn't implement CompareTo() from IComparable, this will trigger runtime exception.

namespace ComparableCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Sorting *****\n");

            // Make an array of Car objects.
            Car[] myAutos = new Car[5];
            myAutos[0] = new Car("Rusty", 80, 1);
            myAutos[1] = new Car("Mary", 40, 234);
            myAutos[2] = new Car("Viper", 40, 34);
            myAutos[3] = new Car("Mel", 40, 4);
            myAutos[4] = new Car("Chucky", 40, 5);

            // Sort my cars? Not yet!
            // Runtim error.
            Array.Sort(myAutos);

            Console.ReadLine();
        }
    }
}
