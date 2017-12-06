using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application FunWithEnums to examine the enumeration type.
//c Add enum EmpType holding 4 items.
//c Update EmpType. I set 102 numerical value for Manager named constant. 

namespace FunWithEnums
{

    // Begin with 102.
    enum EmpType
    {
        Manager = 102,
        Grunt,        // = 103
        Contractor,   // = 104
        VicePresident // = 105
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
