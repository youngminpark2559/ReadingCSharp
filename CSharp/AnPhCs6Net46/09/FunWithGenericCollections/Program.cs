using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application FunWithGenericCollections to examine List<T>.

namespace FunWithGenericCollections
{
    class Program
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }

        static void Main(string[] args)
        {
        }

        static void UseGenericList()
        {
            // Make a List of Person objects, filled with
            // collection/object init syntax.
            List<Person> people = new List<Person>()
              {
                new Person {FirstName= "Homer", LastName="Simpson", Age=47},
                new Person {FirstName= "Marge", LastName="Simpson", Age=45},
                new Person {FirstName= "Lisa", LastName="Simpson", Age=9},
                new Person {FirstName= "Bart", LastName="Simpson", Age=8}
              };

            // Print out # of items in List.
            Console.WriteLine("Items in list: {0}", people.Count);

            // Enumerate over list.
            foreach (Person p in people)
                Console.WriteLine(p);

            // Insert a new person.
            Console.WriteLine("\n->Inserting new person.");
            people.Insert(2, new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });
            Console.WriteLine("Items in list: {0}", people.Count);

            // Copy data into a new array.
            Person[] arrayOfPeople = people.ToArray();
            for (int i = 0; i < arrayOfPeople.Length; i++)
            {
                Console.WriteLine("First Names: {0}", arrayOfPeople[i].FirstName);
            }
        }
    }
}
