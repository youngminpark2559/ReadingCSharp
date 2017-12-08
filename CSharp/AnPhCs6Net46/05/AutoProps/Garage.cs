using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add a class Garage which contains 2 automatic properties. The one has int data type backing field for NumberOfCars and the other one has Car(class) type backing field for MyAuto. At the first time when the Garage class is instantiated, each backing field is assigned by their data type's default value. So, backing field for NumberOfCars is assigned by 0 and backing field for MyAuto is assigned by null.

namespace AutoProps
{
    class Garage
    {
        // The hidden int backing field is set to zero!
        public int NumberOfCars { get; set; }

        // The hidden Car backing field is set to null!
        public Car MyAuto { get; set; }
    }
}
