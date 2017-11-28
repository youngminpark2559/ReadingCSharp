using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a project SimpleDispose.
//c Add a MyResourceWrapper class and it implements IDisposable. Someone will use this class by instantiating this object and after using done he should invoke Dispose() to immediately clean up unmanaged resources and other contained disposable objects from the managed heap. With this Dispose() of IDisposable, I can clean without using Finalize() consuming time and resource of the system.

namespace SimpleDispose
{
    class MyResourceWrapper : IDisposable
    {
        // The object user should call this method
        // when they finish with the object.
        public void Dispose()
        {
            // Clean up unmanaged resources...

            // Dispose other contained disposable objects...

            // Just for a test.
            Console.WriteLine("***** In Dispose! *****");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
