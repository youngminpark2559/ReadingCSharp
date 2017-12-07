using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application NullableTypes.
//c Updata Main() by declaring value data type local variables and assigning null to them. It's going to cause compile-time error. But when I declare string(class) data type local variables and assign null to it, that brings no issue.

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Compiler errors!
            // Value types cannot be set to null!
            //bool myBool = null;
            //int myInt = null;

            // OK! Strings are reference types.
            string myString = null;
        }
    }
}
