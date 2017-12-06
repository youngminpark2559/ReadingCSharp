using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application RefTypeValTypeParams and add a class Person.
//c Add a method SendAPersonByValue(). And I invoke this method with passing Person(class) type instance fred into parameter by value.
//c Add a method SendAPersonByReference(). And I invoke this method from Main() with passing Person(class) type instance into parameter by reference.

namespace RefTypeValTypeParams
{
    class Person
    {
        public string personName;
        public int personAge;

        // Constructors.
        public Person(string name, int age)
        {
            personName = name;
            personAge = age;
        }
        public Person() { }

        public void Display()
        {
            Console.WriteLine("Name: {0}, Age: {1}", personName, personAge);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Passing ref-types by value.
            Console.WriteLine("***** Passing Person object by value *****");
            Person fred = new Person("Fred", 12);
            Console.WriteLine("\nBefore by value call, Person is:");
            fred.Display();
            SendAPersonByValue(fred);
            Console.WriteLine("\nAfter by value call, Person is:");
            fred.Display();

            Person mel = new Person("Mel", 23);
            Console.WriteLine("Before by ref call, Person is:");
            mel.Display();
            SendAPersonByReference(ref mel);
            Console.WriteLine("After by ref call, Person is:");
            mel.Display();

            Console.ReadLine();
        }

        static void SendAPersonByValue(Person p)
        {
            // Change the age of "p"?
            p.personAge = 99;

            // Will the caller see this reassignment?
            p = new Person("Nikki", 99);
        }

        static void SendAPersonByReference(ref Person p)
        {
            // Change some data of "p".
            p.personAge = 555;

            // "p" is now pointing to a new object on the heap!
            p = new Person("Nikki", 999);
        }
    }
}
