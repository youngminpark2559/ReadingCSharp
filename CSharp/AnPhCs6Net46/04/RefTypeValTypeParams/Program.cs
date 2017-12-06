using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application RefTypeValTypeParams and add a class Person.

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
        }
    }
}
