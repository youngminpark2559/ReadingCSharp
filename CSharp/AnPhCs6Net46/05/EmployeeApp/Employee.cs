using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a new cs file Employee.cs and add a class Employee. I add a private fields and a default constructor and a custom constructor and some methods manipulating data of fields.
//c Add a pair of public method, GetName() and SetName(). They allow the object user to manipulate the data of private fields indirectly via these accessor/mutator (get/set method).
//c Add some properties such as Name, ID, and Pay.

namespace EmployeeApp
{
    class Employee
    {
        // Field data.
        private string empName;
        private int empID;
        private float currPay;

        // Properties!
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                else
                    empName = value;
            }
        }

        // We could add additional business rules to the sets of these properties;
        // however, there is no need to do so for this example.
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        // Constructors.
        public Employee() { }
        public Employee(string name, int id, float pay)
        {
            empName = name;
            empID = id;
            currPay = pay;
        }

        // Accessor (get method).
        public string GetName()
        {
            return empName;
        }

        // Mutator (set method).
        public void SetName(string name)
        {
            // Do a check on incoming value
            // before making assignment.
            if (name.Length > 15)
                Console.WriteLine("Error! Name length exceeds 15 characters!");
            else
                empName = name;
        }

        // Methods.
        public void GiveBonus(float amount)
        {
            currPay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Pay: {0}", currPay);
        }
    }


}
