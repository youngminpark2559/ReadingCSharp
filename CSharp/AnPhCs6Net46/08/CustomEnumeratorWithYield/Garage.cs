using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Update a class Garage. I add a method GetEnumerator() using "yield return syntax" inside of foreach iteration loop.
//c Update a class Garage. I update a method GetEnumerator() using multiple "yield return syntax" without using foreach iteration loop.
//c Add a method GetTheCars which is the "named iterator".

namespace CustomEnumeratorWithYield
{
    public class Garage : IEnumerable
    {
        // System.Array already implements IEnumerator!
        private Car[] carArray = new Car[4];

        public Garage()
        {
            carArray[0] = new Car("FeeFee", 200);
            carArray[1] = new Car("Clunker", 90);
            carArray[2] = new Car("Zippy", 30);
            carArray[3] = new Car("Fred", 30);
        }


        public IEnumerator GetEnumerator()
        {
            // Return the array object's IEnumerator.
            return carArray.GetEnumerator();

        }

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    // Return the array object's IEnumerator.
        //    return carArray.GetEnumerator();
        //}

        //// Iterator method.
        //public IEnumerator GetEnumerator()
        //{
        //    foreach (Car c in carArray)
        //    {
        //        yield return c;
        //    }
        //}

        //public IEnumerator GetEnumerator()
        //{
        //    yield return carArray[0];
        //    yield return carArray[1];
        //    yield return carArray[2];
        //    yield return carArray[3];
        //}

        public IEnumerable GetTheCars(bool ReturnRevesed)
        {
            // Return the items in reverse.
            if (ReturnRevesed)
            {
                for (int i = carArray.Length; i != 0; i--)
                {
                    yield return carArray[i - 1];
                }
            }
            else
            {
                // Return the items as placed in the array.
                foreach (Car c in carArray)
                {
                    yield return c;
                }
            }
        }
    }
}
