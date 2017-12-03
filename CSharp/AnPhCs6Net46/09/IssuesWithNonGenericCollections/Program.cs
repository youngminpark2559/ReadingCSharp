using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add ArrayListOfRandomObjects() to show that I can add any types into ArrayList because ArrayList members are prototyped to object type.

namespace IssuesWithNonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void SimpleBoxUnboxOperation()
        {
            // Make a ValueType (int) variable.
            int myInt = 25;

            // Box the int into an object reference.
            object boxedInt = myInt;

            // Unbox in the wrong data type to trigger
            // runtime exception.
            try
            {
                long unboxedInt = (long)boxedInt;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void WorkWithArrayList()
        {
            // Value types are automatically boxed when
            // passed to a method requesting an object.
            ArrayList myInts = new ArrayList();
            myInts.Add(10);
            myInts.Add(20);
            myInts.Add(35);
        }

        static void ArrayListOfRandomObjects()
        {
            // The ArrayList can hold anything at all.
            ArrayList allMyObjects = new ArrayList();
            allMyObjects.Add(true);
            allMyObjects.Add(new OperatingSystem(PlatformID.MacOSX, new Version(10, 0)));
            allMyObjects.Add(66);
            allMyObjects.Add(3.14);
        }
    }
}
