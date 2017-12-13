using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add a class ThreeDCircle with pretending I get this class from third-party.
//c Inherit Circle class from ThreeDCircle.
//c Add a new keyword to explicitly state Draw() in ThreeDCircle hides Draw() in base class Circle, Shape.
//c Add a new keyword to string data type field PetName which hides PetName in base class..

namespace CustomInterface
{
    // Hexagon now implements IPointy.
    class Hexagon : Shape, IPointy
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        public override void Draw()
        { Console.WriteLine("Drawing {0} the Hexagon", PetName); }

        // IPointy implementation.
        public byte Points
        {
            get { return 6; }
        }
    }
}
