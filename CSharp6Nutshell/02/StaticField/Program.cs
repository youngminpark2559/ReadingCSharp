using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticField
{
    public class Panda
    {
        public string Name;             // Instance field
        public static int Population;   // Static field

        public Panda(string n)         // Constructor
        {
            Name = n;                     // Assign the instance field
            Population = Population + 1;  // Increment the static Population field
        }
    }

    class Program
    {
        static void Main()
        {
            Panda p1 = new Panda("Pan Dee");
            Panda p2 = new Panda("Pan Dah");

            Console.WriteLine(p1.Name);      // Pan Dee
            Console.WriteLine(p2.Name);      // Pan Dah

            Console.WriteLine(Panda.Population);   // 2
        }
    }
}
