using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application ObjectOverrides to examine System.Object class, the top base class for all types.
//c Add a class Person. Update a method Main(). In this method, I use overriden method ToString from Object class. And assign the reference value of p1 to p2 and assign assigned value to p2 to o and check object o referencing is the same with the object p1 referencing and do same thing for p2 and o.
//c Override a virtual method ToString() from System.Object class in Person(class) type.

namespace ObjectOverrides
{
    // Remember! Person extends Object.
    class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }

        public Person(string fName, string lName, int personAge)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
        }
        public Person() { }

        public override string ToString()
        {
            string myState;
            myState = string.Format("[First Name: {0}; Last Name: {1}; Age: {2}]",
              FirstName, LastName, Age);
            return myState;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with System.Object *****\n");
            Person p1 = new Person();

            // Use inherited members of System.Object.
            Console.WriteLine("ToString: {0}", p1.ToString());
            Console.WriteLine("Hash code: {0}", p1.GetHashCode());
            Console.WriteLine("Type: {0}", p1.GetType());

            // Make some other references to p1.
            Person p2 = p1;
            object o = p2;
            // Are the references pointing to the same object in memory?
            if (o.Equals(p1) && p2.Equals(o))
            {
                Console.WriteLine("Same instance!");
            }
            Console.ReadLine();
        }
    }
}
