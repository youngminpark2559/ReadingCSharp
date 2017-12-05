using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application ImplicitlyTypedLocalVars to exmaine implicitly typed local variable by using var keyword.
//c Add a DeclareImplicitVars() to use var keyword to declare local variable value type.

namespace ImplicitlyTypedLocalVars
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void DeclareImplicitVars()
        {
            // Implicitly typed local variables
            // are declared as follows:
            // var variableName = initialValue;
            var myInt = 0;
            var myBool = true;
            var myString = "Time, marches on...";
        }
    }
}
