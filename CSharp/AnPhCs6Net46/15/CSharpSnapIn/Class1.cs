using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonSnappableTypes;
using System.Windows.Forms;

//c Create a class library CSharpSnapIn. This dll file will be used in executable application as a plug in along with CommonSnappableTypes.dll.

namespace CSharpSnapIn
{
    [CompanyInfo(CompanyName = "FooBar", CompanyUrl = "www.FooBar.com")]
    public class CSharpModule : IAppFunctionality
    {
        void IAppFunctionality.DoIt()
        {
            MessageBox.Show("You have just used the C# snap-in!");
        }
    }
}