using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application InterfaceNameClash and add 3 interfaces.
//c Test code before using "explicit interface member implementation syntax".
//c Update a method Main(). I invoke each implemented Draw() located in Octagon by doing explicit type cast.

namespace InterfaceNameClash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interface Name Clashes *****\n");
            Octagon oct = new Octagon();

            // We now must use casting to access the Draw()
            // members.
            IDrawToForm itfForm = (IDrawToForm)oct;
            itfForm.Draw();

            // Shorthand notation if you don't need
            // the interface variable for later use.
            ((IDrawToPrinter)oct).Draw();

            // Could also use the "is" keyword.
            if (oct is IDrawToMemory)
                ((IDrawToMemory)oct).Draw();

            Console.ReadLine();
        }
    }
}
