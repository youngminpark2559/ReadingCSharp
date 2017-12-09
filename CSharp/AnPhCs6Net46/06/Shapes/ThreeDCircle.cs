using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add a class ThreeDCircle with pretending I get this class from third-party.
//c Inherit Circle class from ThreeDCircle.

namespace Shapes
{
    class ThreeDCircle : Circle
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a 3D Circle");
        }
    }
}
