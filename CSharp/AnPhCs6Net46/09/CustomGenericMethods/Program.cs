using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console applicatioin CustomGenericMethods.
//c Add Swap().

namespace CustomGenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        // Swap two integers.
        static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

    }
}
