using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application ObjectOverrides to examine System.Object class, the top base class for all types.
//c Add a class Person. Update a method Main(). In this method, I use overriden method ToString from Object class. And assign the reference value of p1 to p2 and assign assigned value to p2 to o and check object o referencing is the same with the object p1 referencing and do same thing for p2 and o.
//c Override a virtual method ToString() from System.Object class in Person(class) type.
//c Override a virtual method Equals() from System.Object class. In this class, I take Object(class) type argument and check if the type of obj is compatable to Person(class) type and check if obj is not null. If so, I explicit type cast obj to Person(class) type and compare the passed instance's FirstName's backing field data and this(class) type instance's FirstName's backing field data. And do the same thing for LastName and Age. If all instance state data between 2 instances are same, it returns ture.
//c I can do same thing comparing 2 instances's state data by using ToString(). With this approach, I don't need to do explicit type case from the type of obj being passed as an argument to Person(class) type. By this default ToString() inherited from System.Object class, I get obj instance's fully qualified name and this class instance's fully qualified name and compare 2 string values I got by == operator.
//c Add a field string data type SSN.
//c Override a virtual method GetHashCode() from System.Object class. When this method is invoked, get instance state data from backing field via SSN property, and on that type of data, invoke GetHashCode() to hash the value of SSN's backing field data.
//c If you cannot find a single point of unique string data(SSN backing field data in this example) but you have overridden ToString(), call GetHashCode() on your own string representation like this this.ToString().GetHashCode();
//c Updata a method Main(). I instantiate 2 instances which have same objest state data. On each instance, I call overridden ToString() to get a string value composed of each instance's object state data. And I compare those 2 instances by overridden Equals(). And I get hash code of each instance and compare if they're same. And then I change instance p2's Age backing field data from 50 to 45. Now the results of ToString() on p1, p2 are different. And p1 and p2 are not equal. And their hash code is not equal.
//c Add a static method StaticMembersOfObject() which uses static members Equals() and ReferenceEquals() of System.Object class.

namespace ObjectOverrides
{
    // Remember! Person extends Object.
    class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }
        public string SSN { get; set; } = "";

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

        //public override bool Equals(object obj)
        //{
        //    if (obj is Person && obj != null)
        //    {
        //        Person temp;
        //        temp = (Person)obj;
        //        if (temp.FirstName == this.FirstName
        //          && temp.LastName == this.LastName
        //          && temp.Age == this.Age)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    return false;
        //}

        public override bool Equals(object obj)
        {
            // No need to cast "obj" to a Person anymore,
            // as everything has a ToString() method.
            return obj.ToString() == this.ToString();
        }

        // Return a hash code based on a point of unique string data.
        //public override int GetHashCode()
        //{
        //    return SSN.GetHashCode();
        //}

        // If you cannot find a single point of unique string data but you have overridden ToString(), call GetHashCode() on your own string representation:
        // Return a hash code based on the person's ToString() value.
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with System.Object *****\n");

            // NOTE: We want these to be identical to test
            // the Equals() and GetHashCode() methods.
            Person p1 = new Person("Homer", "Simpson", 50);
            Person p2 = new Person("Homer", "Simpson", 50);

            // Get stringified version of objects.
            Console.WriteLine("p1.ToString() = {0}", p1.ToString());
            Console.WriteLine("p2.ToString() = {0}", p2.ToString());

            // Test overridden Equals().
            Console.WriteLine("p1 = p2?: {0}", p1.Equals(p2));

            // Test hash codes.
            Console.WriteLine("Same hash codes?: {0}", p1.GetHashCode() == p2.GetHashCode());
            Console.WriteLine();
            // Change age of p2 and test again.
            p2.Age = 45;
            Console.WriteLine("p1.ToString() = {0}", p1.ToString());
            Console.WriteLine("p2.ToString() = {0}", p2.ToString());
            Console.WriteLine("p1 = p2?: {0}", p1.Equals(p2));
            Console.WriteLine("Same hash codes?: {0}", p1.GetHashCode() == p2.GetHashCode());
            Console.WriteLine();

            StaticMembersOfObject();
            Console.ReadLine();
        }

        static void StaticMembersOfObject()
        {
            // Static members of System.Object.
            Person p3 = new Person("Sally", "Jones", 4);
            Person p4 = new Person("Sally", "Jones", 4);
            Console.WriteLine("P3 and P4 have same state: {0}", object.Equals(p3, p4));
            Console.WriteLine("P3 and P4 are pointing to same object: {0}",
              object.ReferenceEquals(p3, p4));
        }
    }
}
