using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Interact with properties by assign data into backing fields of properties by using get/set property.

namespace AutoProps
{
    class Car
    {
        // Automatic properties.
        // No need to define backing fields.
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }

        // Read-only property? This is OK!
        public int MyReadOnlyProp { get; }
        // Write only property? Error!
        //public int MyWriteOnlyProp { set; }

        public void DisplayStats()
        {
            Console.WriteLine("Car Name: {0}", PetName);
            Console.WriteLine("Speed: {0}", Speed);
            Console.WriteLine("Color: {0}", Color);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Automatic Properties *****\n");

            Car c = new Car();
            c.PetName = "Frank";
            c.Speed = 55;
            c.Color = "Red";

            Console.WriteLine("Your car is named {0}? That's odd...",
              c.PetName);
            c.DisplayStats();

            Console.ReadLine();
        }
    }
}
