using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

//c Create a project CustomSerialization to examine how to configure the process of a serialization by using ISerializable.

namespace CustomSerialization
{
    [Serializable]
    class StringData : ISerializable
    {
        private string dataItemOne = "First data block";
        private string dataItemTwo = "More data";
        public StringData() { }
        protected StringData(SerializationInfo si, StreamingContext ctx)
        {
            // Rehydrate member variables from stream.
            dataItemOne = si.GetString("First_Item").ToLower();
            dataItemTwo = si.GetString("dataItemTwo").ToLower();
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext ctx)
        {
            // Fill up the SerializationInfo object with the formatted data.
            info.AddValue("First_Item", dataItemOne.ToUpper());
            info.AddValue("dataItemTwo", dataItemTwo.ToUpper());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
