using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add a class BenefitPackage. This class will be contained by Employee and the functionality of this class(i.e. ComputePayDeduction()) will be exposed in Employee class so that Employee class and derived classes from Employee can access and use BenefitPackage class's functionality.

namespace Employees
{
    // This new type will function as a contained class.
    class BenefitPackage
    {
        // Assume we have other members that represent
        // dental/health benefits, and so on.
        public double ComputePayDeduction()
        {
            return 125.0;
        }
    }
}
