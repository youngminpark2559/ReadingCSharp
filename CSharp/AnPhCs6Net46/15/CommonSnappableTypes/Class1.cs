using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a class library CommonSnappableTypes which will be used in an executable application as a plug-in along with other plug-ins.

namespace CommonSnappableTypes
{
    public interface IAppFunctionality
    {
        void DoIt();
    }
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class CompanyInfoAttribute : System.Attribute
    {
        public string CompanyName { get; set; }
        public string CompanyUrl { get; set; }
    }
}
