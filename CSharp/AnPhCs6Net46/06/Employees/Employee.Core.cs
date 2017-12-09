using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Update a class Employee to change access modifiers from private to protected for each fields. Now any derived classes from this base class Employee can access and use these fields' data without via public properties and public methods.
//c Add a BenefitPackage(class) data type private field empBenefits and I initialize object of BenefitPackage on declaration.
//c Add a method GetBenefitCost() which uses funtionality of BenefitPackage class (ComputePayDeduction()) and a property Benefits which returns BenefitPackage object and sets BenefitPackage object.

namespace Employees
{
    partial class Employee
    {
        // Derived classes can now directly access this information.
        protected string empName;
        protected int empID;
        protected float currPay;
        protected int empAge;
        protected string empSSN;
        // Contain a BenefitPackage object.
        protected BenefitPackage empBenefits = new BenefitPackage();

        // Note use of constructor chaining.
        public Employee() { }
        public Employee(string name, int id, float pay)
          : this(name, 0, id, pay)
        { }
        public Employee(string name, int age, int id, float pay)
        {
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
        }

        // Add to the Employee base class.
        public Employee(string name, int age, int id, float pay, string ssn) : this(name, age, id, pay)
        {
            empSSN = ssn;
        }



        // Properties!
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error!  Name length exceeds 15 characters");
                else
                    empName = value;
            }
        }

        // We could add additional business rules to the sets of these properties,
        // however there is no need to do so for this example.
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
        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public string SocialSecurityNumber
        {
            get { return empSSN; }
        }


        // Expose certain benefit behaviors of object.
        public double GetBenefitCost()
        { return empBenefits.ComputePayDeduction(); }

        // Expose object through a custom property.
        public BenefitPackage Benefits
        {
            get { return empBenefits; }
            set { empBenefits = value; }
        }
    }
}
