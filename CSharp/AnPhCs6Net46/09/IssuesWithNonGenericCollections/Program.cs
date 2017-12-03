using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add ArrayListOfRandomObjects() to show that I can add any types into ArrayList because ArrayList members are prototyped to object type.
//c Add a Person class.
//c Add a PersonCollection class. Within this class, I instantiate one ArrayList and I put ArrayList members especially method into PersonCollection methods which get Person type argument with playing a role of like a filter.
//c Add UseGenericList(). This is generic collection class. Within this class, I use generic List<Person> and List<int>.

namespace IssuesWithNonGenericCollections
{

    public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person() { }
        public Person(string firstName, string lastName, int age)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1}, Age: {2}",
              FirstName, LastName, Age);
        }
    }

    public class PersonCollection : IEnumerable
    {
        private ArrayList arPeople = new ArrayList();

        // Cast for caller.
        public Person GetPerson(int pos)
        { return (Person)arPeople[pos]; }

        // Insert only Person objects.
        public void AddPerson(Person p)
        { arPeople.Add(p); }

        public void ClearPeople()
        { arPeople.Clear(); }

        public int Count
        { get { return arPeople.Count; } }

        // Foreach enumeration support.
        IEnumerator IEnumerable.GetEnumerator()
        { return arPeople.GetEnumerator(); }
    }

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

        static void UsePersonCollection()
        {
            Console.WriteLine("***** Custom Person Collection *****\n");
            PersonCollection myPeople = new PersonCollection();
            myPeople.AddPerson(new Person("Homer", "Simpson", 40));
            myPeople.AddPerson(new Person("Marge", "Simpson", 38));
            myPeople.AddPerson(new Person("Lisa", "Simpson", 9));
            myPeople.AddPerson(new Person("Bart", "Simpson", 7));
            myPeople.AddPerson(new Person("Maggie", "Simpson", 2));

            // This would be a compile-time error!
            // myPeople.AddPerson(new Car());

            foreach (Person p in myPeople)
                Console.WriteLine(p);
        }

        static void UseGenericList()
        {
            Console.WriteLine("***** Fun with Generics *****\n");

            // This List<> can hold only Person objects.
            List<Person> morePeople = new List<Person>();
            morePeople.Add(new Person("Frank", "Black", 50));
            Console.WriteLine(morePeople[0]);
            // This List<> can hold only integers.
            List<int> moreInts = new List<int>();
            moreInts.Add(10);
            moreInts.Add(2);
            int sum = moreInts[0] + moreInts[1];

            // Compile-time error! Can't add Person object
            // to a list of ints!
            // moreInts.Add(new Person());
        }
    }
}
