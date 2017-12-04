using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console applicatioin CustomGenericMethods.
//c Add Swap().
//c Add Swap() which is defferent Swap(ref int a, ref int b). This method swaps Person objects incoming to this method.

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

        // Swap two Person objects.
        static void Swap(ref Person a, ref Person b)
        {
            Person temp;
            temp = a;
            a = b;
            b = temp;
        }

    }
}
