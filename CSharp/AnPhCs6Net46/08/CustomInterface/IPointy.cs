using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add a interface IPointy which defines one unimplemented method GetNumberOfPoints().
//c Update a interface IPointy to test what the interface type can't have. Interface type can't have field, can't have a constructor, can't have an implementation of interface's members.
//c Update a interface IPointy. I add property member in interface IPointy. I can add property in various forms like a read-write property (get/set property), a write-only property (set property), and a read-only property (get property).

namespace CustomInterface
{
    // This interface defines the behavior of "having points."
    public interface IPointy
    {
        // A read-write property in an interface would look like:
        // retType PropName { get; set; }
        //
        // while a write-only property in an interface would be:
        // retType PropName { set; }

        byte Points { get; }
    }
}
