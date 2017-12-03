using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application DynamicKeyword to examine "dynamic types" and "DLR(Dynamic Language Runtime). 
//c Add InvokeMembersOnDynamicData() to examine the characteristic of dynamic type.
//c Add comment for InvokeMembersOnDynamicData().

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
            //ChangeObjectDataType();
            //ChangeDynamicDataType();
            //UseObjectVarible();
            InvokeMembersOnDynamicData();
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
            Console.WriteLine(o.GetType());
            // Must cast object as Person to gain access
            // to the Person properties.
            Console.WriteLine("Person's first name is {0}", ((Person)o).FirstName);
        }

        static void PrintThreeStrings()
        {
            var s1 = "Greetings";
            object s2 = "From";
            dynamic s3 = "Minneapolis";

            Console.WriteLine("s1 is of type: {0}", s1.GetType());
            Console.WriteLine("s2 is of type: {0}", s2.GetType());
            Console.WriteLine("s3 is of type: {0}", s3.GetType());
        }

        static void ChangeDynamicDataType()
        {
            // Declare a single dynamic data point named "t".
            dynamic t = "Hello!";
            Console.WriteLine("t is of type: {0}", t.GetType());

            t = false;
            Console.WriteLine("t is of type: {0}", t.GetType());

            t = new List<int>();
            Console.WriteLine("t is of type: {0}", t.GetType());
        }

        static void ChangeVarDataType()
        {
            //Now, t is strongly type by string.
            //var t = "Hello!";
            //Console.WriteLine("t is of type: {0}", t.GetType());

            ////I can't assign boolean type value into string type variable.
            ////Compile time error.
            //t = false;
            //Console.WriteLine("t is of type: {0}", t.GetType());

            ////Compile time error.
           var t = new List<int>();
            //Console.WriteLine("t is of type: {0}", t.GetType());
        }

        static void ChangeObjectDataType()
        {
            object t = "Hello!";
            Console.WriteLine("t is of type: {0}", t.GetType());

            t = false;
            Console.WriteLine("t is of type: {0}", t.GetType());

            t = new List<int>();
            Console.WriteLine("t is of type: {0}", t.GetType());

        }

        static void InvokeMembersOnDynamicData()
        {
            dynamic textData1 = "Hello";
            //ToUpper() is method of String type.
            Console.WriteLine(textData1.ToUpper());

            // You would expect compiler errors here!
            // But they compile just fine.
            // Compile is possibe(ctrl shift b). Run is failed(click exe file.) 
            Console.WriteLine(textData1.toupper());
            Console.WriteLine(textData1.Foo(10, "ee", DateTime.Now));
        }
    }
}
