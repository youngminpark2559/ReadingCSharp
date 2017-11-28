using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a project SimpleGC and add a Car class.
//c Instantiate Car object with passing 2 arguments and use that instantiated instance by using dot operator.
//c Add methods to show the bytes on the heap and object generations and so on.
//c Use GC.Collect() and GC.WaitForPendingFinalizers() to execute garbage collection immediately and suspend the calling thread for object which I want to delete. 
//c Add a test functionality to instantiate many objects and execute the garbage collection and see what happened.

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
            //Console.WriteLine("***** GC Basics *****");

            //// Create a new Car object on
            //// the managed heap. We are
            //// returned a reference to this
            //// object ("refToMyCar").
            //Car refToMyCar = new Car("Zippy", 50);

            //// The C# dot operator (.) is used
            //// to invoke members on the object
            //// using our reference variable.
            //Console.WriteLine(refToMyCar.ToString());
            //Console.ReadLine();




            //Console.WriteLine("***** Fun with System.GC *****");

            //// Print out estimated number of bytes on heap.
            //Console.WriteLine("Estimated bytes on heap: {0}", GC.GetTotalMemory(false));

            //// MaxGeneration is zero based, so add 1 for display purposes.
            //Console.WriteLine("This OS has {0} object generations.\n", (GC.MaxGeneration + 1));

            //Car refToMyCar = new Car("Zippy", 100);
            //Console.WriteLine(refToMyCar.ToString());

            //// Print out generation of refToMyCar object.
            //Console.WriteLine("Generation of refToMyCar is: {0}", GC.GetGeneration(refToMyCar));

            //// Force a garbage collection immediately.
            //GC.Collect();
            //// And wait for each object to be finalized.
            //// Using GC.WaitForPendingFinalizers() is mandatory when you use GC.Collect()
            //GC.WaitForPendingFinalizers();

            //// Only investigate generation 0 objects.
            //GC.Collect(0);
            //GC.WaitForPendingFinalizers();




            Console.WriteLine("***** Fun with System.GC *****");

            // Print out estimated number of bytes on heap.
            Console.WriteLine("Estimated bytes on heap: {0}", GC.GetTotalMemory(false));

            // MaxGeneration is zero based.
            Console.WriteLine("This OS has {0} object generations.\n", (GC.MaxGeneration + 1));

            Car refToMyCar = new Car("Zippy", 100);
            Console.WriteLine(refToMyCar.ToString());
            // Print out generation of refToMyCar.
            Console.WriteLine("\nGeneration of refToMyCar is: {0}", GC.GetGeneration(refToMyCar));

            // Make a ton of objects for testing purposes.
            object[] tonsOfObjects = new object[50000];
            for (int i = 0; i < 50000; i++)
                tonsOfObjects[i] = new object();

            // Collect only gen 0 objects.
            GC.Collect(0, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();

            // Print out generation of refToMyCar.
            Console.WriteLine("Generation of refToMyCar is: {0}", GC.GetGeneration(refToMyCar));

            // See if tonsOfObjects[9000] is still alive.
            if (tonsOfObjects[9000] != null)
            {
                Console.WriteLine("Generation of tonsOfObjects[9000] is: {0}",
                  GC.GetGeneration(tonsOfObjects[9000]));
            }
            else
                Console.WriteLine("tonsOfObjects[9000] is no longer alive.");

            // Print out how many times a generation has been swept.
            Console.WriteLine("\nGen 0 has been swept {0} times",
              GC.CollectionCount(0));
            Console.WriteLine("Gen 1 has been swept {0} times",
              GC.CollectionCount(1));
            Console.WriteLine("Gen 2 has been swept {0} times",
              GC.CollectionCount(2));


            Console.ReadLine();
        }

        static void MakeACar()
        {
            Car myCar = new Car();
            myCar = null;
        }
    }



}
