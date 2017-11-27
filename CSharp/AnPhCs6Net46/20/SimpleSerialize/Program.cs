using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a project SimpleSerialize. And add a Radio class which is marked with [Serializable] and one field, radioID, in the Radio class is marked with [NonSerialized].
//c Add a Car class which is decorated by [Serializable].

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

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
