using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c I create a Car(class) type instance c1. I create CarEngineHandler(delegate) type instance pointing to CarExploded(). And I add the reference of CarEngineHandler(delegate) type instance pointing to CarExploded() to c1.AboutToBlow event.
//c I simplify above funtionality by using method group conversion syntax.
//c Add a method HookIntoEvents. I add a new event handler method to newCar.AboutToBlow event by using VS.
//c I update a method CarAboutToBlow() which is the event handler method for Exploded event. I update this event handler method to take 2 arguments.
//c I use EventHandler<CarEventArgs>(delegate) type in Main().
//c I update a method Main() by refactoring codes by using anonymous methods. I create anonymous methods to be added into events, with not creating methods to be added to events in the scope out of Main().
//c I add Int32(struct) data type local variable aboutToBlowCounter in the scope of Main() defining many anonymous methods. And In the anonymous method, I increment aboutToBlowCounter local variable value by one. In the end, aboutToBlowCounter becomes 2.

namespace CarEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Events *****\n");
            //Car c1 = new Car("SlugBug", 100, 10);

            //// Register event handlers.
            //c1.AboutToBlow += CarIsAlmostDoomed;
            //c1.AboutToBlow += CarAboutToBlow;

            //EventHandler<CarEventArgs> d = new EventHandler<CarEventArgs>(CarExploded);
            //c1.Exploded += d;
            //Console.WriteLine("***** Speeding up *****");
            //for (int i = 0; i < 6; i++)
            //    c1.Accelerate(20);

            //// Remove CarExploded method
            //// from invocation list.
            //c1.Exploded -= d;

            //Console.WriteLine("\n***** Speeding up *****");
            //for (int i = 0; i < 6; i++)
            //    c1.Accelerate(20);

            Console.WriteLine("***** Anonymous Methods *****\n");

            int aboutToBlowCounter = 0;

            // Make a car as usual.
            Car c1 = new Car("SlugBug", 100, 10);

            // Register event handlers as anonymous methods.
            c1.AboutToBlow += delegate
            {
                aboutToBlowCounter++;
                Console.WriteLine("Eek! Going too fast!");
            };

            c1.AboutToBlow += delegate (object sender, CarEventArgs e)
            {
                aboutToBlowCounter++;
                Console.WriteLine("Critical Message from Car: {0}", e.msg);
            };

            // This will eventually trigger the events.
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            Console.WriteLine("AboutToBlow event was fired {0} times.",
              aboutToBlowCounter);

            Console.ReadLine();
        }

        public static void CarAboutToBlow(object sender, CarEventArgs e)
        {
            // Just to be safe, perform a
            // runtime check before casting.
            if (sender is Car)
            {
                Car c = (Car)sender;
                Console.WriteLine("Critical Message from {0}: {1}", c.PetName, e.msg);
            }
        }

        public static void CarIsAlmostDoomed(object sender, CarEventArgs e)
        {
            Console.WriteLine("=> Critical Message from Car:{1} says {0}", sender, e.msg);
        }

        public static void CarExploded(object sender, CarEventArgs e)
        {
            Console.WriteLine(e.msg);
        }

        public static void HookIntoEvents()
        {
            Car newCar = new Car();
            newCar.AboutToBlow += NewCar_AboutToBlow;
        }

        private static void NewCar_AboutToBlow(object sender, CarEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
