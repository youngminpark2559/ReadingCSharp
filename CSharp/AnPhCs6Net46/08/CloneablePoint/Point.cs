using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add a class Point.
//c Update a class Point to derive from ICloneable. And I implement Clone() from ICloneable to internally instantiate new Point type object and copy the values of p1's fields to p2's fields and return this instance's reference to the caller.
//c Refactor a method Clone(). I'm copying only value type variable data(int x = 100) I can simplify this method by using MemberwiseClone(). But If there's a reference type variable data(Person x = person1) this approach results in just a shallow copy so you should be careful.
//c Update a class Point. I add a PointDescription(class) type field desc. And I add a custom constructor and override ToString() to make the desc used.

namespace CloneablePoint
{
    public class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription desc = new PointDescription();

        public Point(int xPos, int yPos, string petName)
        {
            X = xPos; Y = yPos;
            desc.PetName = petName;
        }
        public Point(int xPos, int yPos)
        {
            X = xPos; Y = yPos;
        }
        public Point() { }

        // Override Object.ToString().
        public override string ToString()
        {
            return string.Format("X = {0}; Y = {1}; Name = {2};\nID = {3}\n",
            X, Y, desc.PetName, desc.PointID);
        }

        // Now we need to adjust for the PointDescription member.
        public object Clone()
        {
            // First get a shallow copy.
            Point newPoint = (Point)this.MemberwiseClone();

            // Then fill in the gaps.
            PointDescription currentDesc = new PointDescription();
            currentDesc.PetName = this.desc.PetName;
            newPoint.desc = currentDesc;
            return newPoint;
        }
    }
}
