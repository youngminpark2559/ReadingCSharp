using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add a class Octagon which implements 3 interfaces such as IDrawToForm, IDrawToMemory, IDrawToPrinter. And Octagon implements Draw().
//c Update a class Octagon. I implement Draw() from each interface by using "explicit interface member implementation syntax".

namespace InterfaceNameClash
{
    class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        // Explicitly bind Draw() implementations
        // to a given interface.
        void IDrawToForm.Draw()
        {
            Console.WriteLine("Drawing to form...");
        }
        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Drawing to memory...");
        }
        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Drawing to a printer...");
        }
    }
}
