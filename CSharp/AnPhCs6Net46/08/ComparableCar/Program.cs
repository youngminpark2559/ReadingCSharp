using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c I try to invoke Sort() with passing Car[](class) type instance myAutos. But the array of the custom(class) type Car doesn't implement CompareTo() from IComparable, this will trigger runtime exception.
//c Test functionality by using CompareTo() I implemented from IComparable.
//c I sort myAutos by 2 criterias. One is CarID. And the other one is pet name.

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

            // Display current array.
            Console.WriteLine("Here is the unordered set of cars:");
            foreach (Car c in myAutos)
                Console.WriteLine("{0} {1}", c.CarID, c.PetName);

            // Now, sort them using IComparable!
            Array.Sort(myAutos);
            Console.WriteLine();
            // Display sorted array.
            Console.WriteLine("Here is the ordered set of cars:");
            foreach (Car c in myAutos)
                Console.WriteLine("{0} {1}", c.CarID, c.PetName);

            // Now sort by pet name.
            Array.Sort(myAutos, new PetNameComparer());

            // Dump sorted array.
            Console.WriteLine("Ordering by pet name:");
            foreach (Car c in myAutos)
                Console.WriteLine("{0} {1}", c.CarID, c.PetName);

            Console.ReadLine();
        }
    }
}
