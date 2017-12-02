using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a class library AttributedCarLibrary to examine how to create and use a custom attribute.
//c To test a custom attribute feature, add several classes decorated by some attributes.

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

    // Assign description using a "named property."
    [Serializable]
    [VehicleDescription(Description = "My rocking Harley")]
    public class Motorcycle
    {
    }

    [Serializable]
    [Obsolete("Use another vehicle!")]
    [VehicleDescription("The old gray mare, she ain't what she used to be...")]
    public class HorseAndBuggy
    {
    }

    [VehicleDescription("A very long, slow, but feature-rich auto")]
    public class Winnebago
    {
    }


    public class Class1
    {
    }
}
