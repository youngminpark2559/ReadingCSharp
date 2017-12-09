using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console app Employees.
//c It's still impossible for object user (from outside) to access to the protected field directly. protected fields can be accessed by the class defining it or derived class from the defining class.
//c Update a method Main(). Via Manager(class) type object derived from Employee, I invoke GetBenefitCost() inherited from its base class Employee with using functionality of BenefitPackage class GetBenefitCost().

namespace Employees
{
    class Program
    {
        // Create a subclass object and access base class functionality.
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");
            SalesPerson fred = new SalesPerson();
            fred.Age = 31;
            fred.Name = "Fred";
            fred.SalesNumber = 50;

            // Assume Manager has a constructor matching this signature:
            // (string fullName, int age, int empID, float currPay, string ssn, int numbOfOpts)
            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            Console.WriteLine(chucky.Name);

            // Error! Can't access protected data from client code.
            //Employee emp = new Employee();
            //emp.empName = "Fred";

            double cost = chucky.GetBenefitCost();
            Console.WriteLine($"cost: {cost}");

            Console.ReadLine();
        }
    }
}