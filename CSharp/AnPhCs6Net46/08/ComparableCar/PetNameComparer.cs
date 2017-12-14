using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add a class PetNameComparer. I make this class derive from IComparer. And I implement Compare() from IComparer. And inside of Comparer(), I use Comparer() implemented by String(class) type to compare 2 string(class) data type literals.

namespace ComparableCar
{
    // This helper class is used to sort an array of Cars by pet name.
    public class PetNameComparer : IComparer
    {
        // Test the pet name of each object.
        int IComparer.Compare(object o1, object o2)
        {

            Car t1 = o1 as Car;
            Car t2 = o2 as Car;
            if (t1 != null && t2 != null)
                return String.Compare(t1.PetName, t2.PetName);
            else
                throw new ArgumentException("Parameter is not a Car!");
        }
    }
}
