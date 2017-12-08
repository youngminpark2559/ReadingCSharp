using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a new cs file Employee.cs and add a class Employee. I add a private fields and a default constructor and a custom constructor and some methods manipulating data of fields.
//c Add a pair of public method, GetName() and SetName(). They allow the object user to manipulate the data of private fields indirectly via these accessor/mutator (get/set method).
//c Add some properties such as Name, ID, and Pay.
//c Update DisplayStats(), a custom constructor by using constructor chaining, new private field empAge, Age property.
//c Update a custom constructor Employee by writing validation logic isside of constructor. This is bad practice by generating duplicate codes located in property.
//c Refactor a custom constructor Employee by isolating validation code towards properties.
//c Add a private field empSSN and a get property SocialSecurityNumber.

namespace EmployeeApp
{
    class Employee
    {
        // Field data.
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private string empSSN;

        // Constructors.
        public Employee() { }
        public Employee(string name, int id, float pay)
          : this(name, 0, id, pay) { }
        public Employee(string name, int age, int id, float pay)
        {
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
        }

        // Methods.
        public void GiveBonus(float amount)
        { Pay += amount; }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
        }

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

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
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

        public string SocialSecurityNumber
        {
            get { return empSSN; }
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

        // Get/set method for private field empAge.
        public int GetAge()
        {
            return empAge;
        }
        public void SetAge(int age)
        {
            // Do a check on incoming value
            // before making assignment.
            if (age > 1000)
                Console.WriteLine("Error! You put the age over 1000.");
            else
                empAge = age;
        }
    }
}
