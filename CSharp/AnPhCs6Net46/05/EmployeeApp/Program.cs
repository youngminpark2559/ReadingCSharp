using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Updata a method Main() by trying to manipulate the data of private field empName. But I get the compile-time error because of its access modifier.
//c Updata a method Main() by using SetName().
//c Update a method Main() by using SetName() but this time I'm trying to manipulate the data of private field with the data which is not allowed to be stored into the private field by the logic acting like a filter inside of SetName().
//c Manipulate the data of private field empName by using set property and retrieve that data by using get property.

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

            Console.ReadLine();
        }
    }
}
