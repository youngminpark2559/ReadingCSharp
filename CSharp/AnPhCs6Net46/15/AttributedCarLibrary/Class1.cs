using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a class library AttributedCarLibrary to examine how to create and use a custom attribute.

namespace AttributedCarLibrary
{
    // A custom attribute.
    public sealed class VehicleDescriptionAttribute : System.Attribute
    {
        public string Description { get; set; }
        public VehicleDescriptionAttribute(string vehicalDescription)
        {
            Description = vehicalDescription;
        }
        public VehicleDescriptionAttribute() { }
    }

    public class Class1
    {
    }
}
