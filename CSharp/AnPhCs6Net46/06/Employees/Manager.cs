using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add a overriden method GiveBonus().
//c Add a overriden method DisplayStats(). This overriden method is partially use its base class' DisplayStats() logic and also has its own logic.

namespace Employees
{
    // Managers need to know their number of stock options.
    class Manager : Employee
    {
        public int StockOptions { get; set; }

        // Add back the default ctor
        // in the Manager class as well.
        public Manager() { }

        public Manager(string fullName, int age, int empID,
               float currPay, string ssn, int numbOfOpts)
            : base(fullName, age, empID, currPay, ssn)
        {
            // This property is defined by the Manager class.
            StockOptions = numbOfOpts;
        }

        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions += r.Next(500);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Stock Options: {0}", StockOptions);
        }
    }
}
