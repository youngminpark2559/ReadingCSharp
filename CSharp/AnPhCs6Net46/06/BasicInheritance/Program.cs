using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    // A simple base class.
    class Car
    {
        public readonly int maxSpeed;
        private int currSpeed;

        public Car(int max)
        {
            maxSpeed = max;
        }
        public Car()
        {
            maxSpeed = 55;
        }
        public int Speed
        {
            get { return currSpeed; }
            set
            {
                currSpeed = value;
                if (currSpeed > maxSpeed)
                {
                    currSpeed = maxSpeed;
                }
            }
        }
    }

    // MiniVan derives from Car.
    sealed class MiniVan : Car
    {
        public void TestMethod()
        {
            // OK! Can access public members
            // of a parent within a derived type.
            Speed = 10;

            // Error! Cannot access private
            // members of parent within a derived type.
            //currSpeed = 10;
        }
    }

    // Error! Cannot extend
    // a class marked with the sealed keyword!
    //class DeluxeMiniVan : MiniVan
    //{ }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Inheritance *****\n");
            // Make a Car object and set max speed.
            Car myCar = new Car(80);

            // Set the current speed, and print it.
            myCar.Speed = 50;
            Console.WriteLine("My car is going {0} MPH", myCar.Speed);

            // Now make a MiniVan object.
            MiniVan myVan = new MiniVan();
            myVan.Speed = 10;
            Console.WriteLine("My van is going {0} MPH", myVan.Speed);

            // Error! Can't access private members!
            //myVan.currSpeed = 55;

            Console.ReadLine();
        }
    }
}
