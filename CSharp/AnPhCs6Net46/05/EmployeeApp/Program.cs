using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Updata a method Main() by trying to manipulate the data of private field empName. But I get the compile-time error because of its access modifier.

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            // Error! Cannot directly access private members
            // from an object!
            //emp.empName = "Marv";
        }
    }
}
