using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application FunWithEnums to examine the enumeration type.
//c Add enum EmpType holding 4 items.
//c Update EmpType. I set 102 numerical value for Manager named constant. 
//c Update EmpType. In enum, named constant should be unique. But numerical value for the named constant doesn't need to be unique. And also numerical value for the named constant doesn't need to follow sequential ordering.
//c Update EmpType. I can change the underlying data type (byte, short, int, or long) for numerical value mapped to the corresponding named constant.

namespace FunWithEnums
{

    // This time, EmpType maps to an underlying byte.
    enum EmpType : byte
    {
        Manager = 10,
        Grunt = 1,
        Contractor = 100,
        VicePresident = 9
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
