using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a project ApplyingAttributes to examine how to use attribute feature.
//c Add a class Motorcycle which is decorated by [Serializable] and some of its members are decorated by [NonSerialized].
//c Add a class HorseAndBuggy which is decorated by [Serializable] and [Obsolete].
//c Instantiate HorseAndBuggy object and I compile and I get a warning message that I'm using obsolete members.

namespace ApplyingAttributes
{
    // This class can be saved to disk.
    [Serializable]
    public class Motorcycle
    {
        // However, this field will not be persisted.
        [NonSerialized]
        float weightOfCurrentPassengers;

        // These fields are still serializable.
        bool hasRadioSystem;
        bool hasHeadSet;
        bool hasSissyBar;
    }



    [Serializable, Obsolete("Use another vehicle!")]
    public class HorseAndBuggy
    {
        // ...
    }

    class Program
    {
        static void Main(string[] args)
        {
            HorseAndBuggy mule = new HorseAndBuggy();
        }
    }
}
