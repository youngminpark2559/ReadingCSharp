using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a project SimpleGC and add a Car class.
//c Instantiate Car object with passing 2 arguments and use that instantiated instance by using dot operator.

namespace SimpleGC
{
    // Car.cs
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }

        public Car() { }
        public Car(string name, int speed)
        {
            PetName = name;
            CurrentSpeed = speed;
        }
        public override string ToString()
        {
            return string.Format("{0} is going {1} MPH",
              PetName, CurrentSpeed);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** GC Basics *****");

            // Create a new Car object on
            // the managed heap. We are
            // returned a reference to this
            // object ("refToMyCar").
            Car refToMyCar = new Car("Zippy", 50);

            // The C# dot operator (.) is used
            // to invoke members on the object
            // using our reference variable.
            Console.WriteLine(refToMyCar.ToString());
            Console.ReadLine();
        }
    }
}
