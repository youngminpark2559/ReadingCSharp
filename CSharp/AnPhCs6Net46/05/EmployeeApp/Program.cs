using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Updata a method Main() by trying to manipulate the data of private field empName. But I get the compile-time error because of its access modifier.
//c Updata a method Main() by using SetName().
//c Update a method Main() by using SetName() but this time I'm trying to manipulate the data of private field with the data which is not allowed to be stored into the private field by the logic acting like a filter inside of SetName().
//c Manipulate the data of private field empName by using set property and retrieve that data by using get property.
//c Compare the use way between get/set method and property when I manipulate the data of private field. Property one is more simple and intuitive.
// Update a method Main() and a class Employee. I set a custom constructor which takes 4 parameter with using the optional parameter syntax. And in the Main(), I invoke that custom constructor by using named argument syntax.

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Error! Cannot directly access private members
            // from an object!
            //emp.empName = "Marv";

            Console.WriteLine("***** Fun with Encapsulation *****\n");
            Employee emp = new Employee("Marvin", 456, 30000);
            emp.GiveBonus(1000);
            emp.DisplayStats();
            // Use the get/set methods to interact with the object's name.
            emp.SetName("Marv");
            Console.WriteLine("Employee is named: {0}", emp.GetName());

            // Longer than 15 characters! Error will print to console.
            Employee emp2 = new Employee();
            emp2.SetName("Xena the warrior princess");

            // Reset and then get the Name property.
            emp.Name = "Marv";
            Console.WriteLine("Employee is named: {0}", emp.Name);

            Employee joe = new Employee(age: 10);
            Console.WriteLine($"By get/set method and before: {joe.GetAge()}");
            joe.SetAge(joe.GetAge() + 1);
            Console.WriteLine($"By get/set method and after: {joe.GetAge()}");

            Employee joe2 = new Employee(age: 10);
            Console.WriteLine($"By property and before: {joe2.Age}");
            joe2.Age++;
            Console.WriteLine($"By property and after: {joe2.Age}");


            Console.ReadLine();
        }
    }
}
