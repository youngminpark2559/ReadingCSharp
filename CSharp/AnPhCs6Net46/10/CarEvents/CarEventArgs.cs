using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c I add a CarEventArgs(class) type which derives from EventArgs(class) type.

namespace CarEvents
{
    public class CarEventArgs : EventArgs
    {
        public readonly string msg;
        public CarEventArgs(string message)
        {
            msg = message;
        }
    }
}
