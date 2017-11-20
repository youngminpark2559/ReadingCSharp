using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a HelloProgram.cs and compile it, resulting in the HelloProgram.exe assembly. Open this assembly by ILDASM.exe and dump IL code into a file, HelloProgram.il. HelloProgram.res is a resource file and it contains low level CLR security information.

namespace HelloProgram
{
    // Note that we are not wrapping our class in a namespace,
    // to help simplify the generated CIL code.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello CIL code!");
            Console.ReadLine();
        }
    }
}
