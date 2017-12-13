using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add a class ThreeDCircle with pretending I get this class from third-party.
//c Inherit Circle class from ThreeDCircle.
//c Add a new keyword to explicitly state Draw() in ThreeDCircle hides Draw() in base class Circle, Shape.
//c Add a new keyword to string data type field PetName which hides PetName in base class..
//c Update a class ThreeDCircle by implementing Draw3D() from IDraw3D.

namespace CustomInterface
{
    class ThreeDCircle : Circle, IDraw3D
    {
        // Hide the PetName property above me.
        public new string PetName { get; set; }

        // Hide any Draw() implementation above me.
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D Circle");
        }

        public void Draw3D()
        {
            Console.WriteLine("Drawing Circle in 3D!");
        }
    }
}
