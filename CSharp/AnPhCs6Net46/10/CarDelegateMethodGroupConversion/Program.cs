using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application CarDelegateMethodGroupConversion.
//c I use "method group conversion syntax" to register CarEngineHandler(delegate) type instance pointing to CallMeHere() to CarEngineHandler(delegate) type instance's invocation list (listOfHandlers) by passing method name I want to register into that invocation list rather than passing CarEngineHandler(delegate) type instance pointing to CallMeHere().

namespace CarDelegateMethodGroupConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Method Group Conversion *****\n");
            Car c1 = new Car();

            // Register the simple method name.
            c1.RegisterWithCarEngine(CallMeHere);

            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            // Unregister the simple method name.
            c1.UnRegisterWithCarEngine(CallMeHere);

            // No more notifications!
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            Console.ReadLine();
        }

        static void CallMeHere(string msg)
        {
            Console.WriteLine("=> Message from Car: {0}", msg);
        }
    }
}
