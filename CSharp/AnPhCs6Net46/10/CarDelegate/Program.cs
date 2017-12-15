using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application CarDelegate.
//c Update a method Main(). I instantiate CarEngineHandler(delegate) type instance. At the same time of instantiating CarEngineHandler(delegate) type instance, I also register OnCarEngineEvent() in the CarEngineHandler(delegate) type instance's invocation list. And I assign this CarEngineHandler(delegate) type instance to the field listOfHandlers. When carIsDead is true, I pass string "Sorry, this car is dead..." to the method (void OnCarEngineEvent(string msg)) which CarEngineHandler(delegate) type is holding in his invocation list.
//c I register 2 methods into the invocation list of CarEngineHandler(delegate) type instance.

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Delegates as event enablers *****\n");

            // First, make a Car object.
            Car c1 = new Car("SlugBug", 100, 10);

            // Register multiple targets for the notifications.
            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent2));

            // Speed up (this will trigger the events).
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
            Console.ReadLine();
        }
        // We now have TWO methods that will be called by the Car
        // when sending notifications.
        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n***** Message From Car Object *****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("***********************************\n");
        }

        public static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine("=> {0}", msg.ToUpper());
        }
    }
}

