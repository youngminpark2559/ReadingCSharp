using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add a class Octagon which implements 3 interfaces such as IDrawToForm, IDrawToMemory, IDrawToPrinter. And Octagon implements Draw().

namespace InterfaceNameClash
{
    class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        public void Draw()
        {
            // Shared drawing logic.
            Console.WriteLine("Drawing the Octagon...");
        }
    }
}
