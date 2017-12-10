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
