using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add a class Point.
//c Update a class Point to derive from ICloneable. And I implement Clone() from ICloneable to internally instantiate new Point type object and copy the values of p1's fields to p2's fields and return this instance's reference to the caller.
//c Refactor a method Clone(). I'm copying only value type variable data(int x = 100) I can simplify this method by using MemberwiseClone(). But If there's a reference type variable data(Person x = person1) this approach results in just a shallow copy so you should be careful.

namespace CloneablePoint
{
    // The Point now supports "clone-ability."
    public class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int xPos, int yPos) { X = xPos; Y = yPos; }
        public Point() { }

        // Override Object.ToString().
        public override string ToString()
        { return string.Format("X = {0}; Y = {1}", X, Y); }

        //// Return a copy of the current object.
        //public object Clone()
        //{ return new Point(this.X, this.Y); }

        public object Clone()
        {
            // Copy each field of the Point member by member.
            return this.MemberwiseClone();
        }
    }
}
