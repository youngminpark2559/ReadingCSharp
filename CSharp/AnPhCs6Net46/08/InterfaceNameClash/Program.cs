using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application InterfaceNameClash and add 3 interfaces.
//c Test code before using "explicit interface member implementation syntax".

namespace InterfaceNameClash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interface Name Clashes *****\n");
            // All of these invocations call the
            // same Draw() method!
            Octagon oct = new Octagon();
            IDrawToForm itfForm = (IDrawToForm)oct;
            itfForm.Draw();

            IDrawToPrinter itfPriner = (IDrawToPrinter)oct;
            itfPriner.Draw();

            IDrawToMemory itfMemory = (IDrawToMemory)oct;
            itfMemory.Draw();

            Console.ReadLine();
        }
    }
}
