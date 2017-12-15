using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c I create a Car(class) type instance c1. I create CarEngineHandler(delegate) type instance pointing to CarExploded(). And I add the reference of CarEngineHandler(delegate) type instance pointing to CarExploded() to c1.AboutToBlow event.
//c I simplify above funtionality by using method group conversion syntax.
//c Add a method HookIntoEvents. I add a new event handler method to newCar.AboutToBlow event by using VS.
//c I update a method CarAboutToBlow() which is the event handler method for Exploded event. I update this event handler method to take 2 arguments.

namespace CarEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Events *****\n");
            Car c1 = new Car("SlugBug", 100, 10);

            // Register event handlers.
            c1.AboutToBlow += new Car.CarEngineHandler(CarIsAlmostDoomed);
            c1.AboutToBlow += new Car.CarEngineHandler(CarAboutToBlow);

            Car.CarEngineHandler d = new Car.CarEngineHandler(CarExploded);
            c1.Exploded += d;
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            // Remove CarExploded method
            // from invocation list.
            c1.Exploded -= d;

            Console.WriteLine("\n***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
            Console.ReadLine();
        }

        public static void CarAboutToBlow(object sender, CarEventArgs e)
        {
            Console.WriteLine("{0} says: {1}", sender, e.msg);
        }

        public static void CarIsAlmostDoomed(string msg)
        { Console.WriteLine("=> Critical Message from Car: {0}", msg); }

        public static void CarExploded(string msg)
        { Console.WriteLine(msg); }

        public static void HookIntoEvents()
        {
            Car newCar = new Car();
            newCar.AboutToBlow += NewCar_AboutToBlow;
        }

        private static void NewCar_AboutToBlow(string msg)
        {
            throw new NotImplementedException();
        }
    }
}
