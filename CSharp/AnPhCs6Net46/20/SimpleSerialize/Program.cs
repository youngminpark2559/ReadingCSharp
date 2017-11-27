using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a project SimpleSerialize. And add a Radio class which is marked with [Serializable] and one field, radioID, in the Radio class is marked with [NonSerialized].
//c Add a Car class which is decorated by [Serializable].
//c Add a JamesBondCar class which is decorated by [Serializable] and derived from Car base class.
//c Add a Person class to examine the exception for XML format serialization. When I serialize object graph, this ignores members which have a private access. When I need to include private member to serialization, I should use the public property which sets private fields.

namespace SimpleSerialize
{
    [Serializable]
    public class Radio
    {
        public bool hasTweeters;
        public bool hasSubWoofers;
        public double[] stationPresets;

        [NonSerialized]
        public string radioID = "XF-552RR6";
    }


    [Serializable]
    public class Car
    {
        public Radio theRadio = new Radio();
        public bool isHatchBack;
    }



    [Serializable]
    public class JamesBondCar : Car
    {
        public bool canFly;
        public bool canSubmerge;
    }


    [Serializable]
    public class Person
    {
        // A public field.
        public bool isAlive = true;

        // A private field.
        private int personAge = 21;

        // Public property/private data.
        private string fName = string.Empty;
        public string FirstName
        {
            get { return fName; }
            set { fName = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
