using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application DynamicKeyword to examine "dynamic types" and "DLR(Dynamic Language Runtime). 

namespace DynamicKeyword
{ 
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }

        static void ImplicitlyTypedVariable()
        {
            // a is of type List<int>.
            var a = new List<int>();
            a.Add(90);
            // This would be a compile-time error!
            // a = "Hello";
        }

        static void UseObjectVarible()
        {
            // Assume we have a class named Person.
            object o = new Person() { FirstName = "Mike", LastName = "Larson" };

            // Must cast object as Person to gain access
            // to the Person properties.
            Console.WriteLine("Person's first name is {0}", ((Person)o).FirstName);
        }
    }
}
