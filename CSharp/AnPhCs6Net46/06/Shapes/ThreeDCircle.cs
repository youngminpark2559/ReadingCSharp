using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add a class ThreeDCircle with pretending I get this class from third-party.
//c Inherit Circle class from ThreeDCircle.
//c Add a new keyword to explicitly state Draw() in ThreeDCircle hides Draw() in base class Circle, Shape.

namespace Shapes
{
    class ThreeDCircle : Circle
    {
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D Circle");
        }
    }
}
