using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Updata a method Main() by trying to manipulate the data of private field empName. But I get the compile-time error because of its access modifier.
//c Updata a method Main() by using SetName().

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
            Console.ReadLine();
        }
    }
}
