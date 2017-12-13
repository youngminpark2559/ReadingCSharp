using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add a interface IPointy which defines one unimplemented method GetNumberOfPoints().
//c Update a interface IPointy to test what the interface type can't have. Interface type can't have field, can't have a constructor, can't have an implementation of interface's members.

namespace CustomInterface
{
    // This interface defines the behavior of "having points."
    // Ack! Errors abound!
    public interface IPointy
    {
        // Error! Interfaces cannot have data fields!
        public int numbOfPoints;

        // Error! Interfaces do not have constructors!
        public IPointy() { numbOfPoints = 0; }

        // Error! Interfaces don't provide an implementation of members!
        byte GetNumberOfPoints() { return numbOfPoints; }
    }
}
