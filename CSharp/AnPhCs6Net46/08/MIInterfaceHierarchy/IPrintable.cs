using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIInterfaceHierarchy
{
    interface IPrintable
    {
        void Print();
        // Note possible name clash here!
        void Draw(); 
    }
}
