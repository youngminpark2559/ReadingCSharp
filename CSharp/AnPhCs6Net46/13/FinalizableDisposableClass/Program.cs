using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a project FinalizableDisposableClass. A MyResourceWrapper class will use both of ways to clean object from the unmanaged heap. IDisposable and finalizer.

namespace FinalizableDisposableClass
{
    // A sophisticated resource wrapper.
    public class MyResourceWrapper : IDisposable
    {
        // The garbage collector will call this method if the
        // object user forgets to call Dispose().
        ~MyResourceWrapper()
        {
            // Clean up any internal unmanaged resources.
            // Do **not** call Dispose() on any managed objects.
        }
        // The object user will call this method to clean up
        // resources ASAP.
        public void Dispose()
        {
            // Clean up unmanaged resources here.
            // Call Dispose() on other contained disposable objects.
            // No need to finalize if user called Dispose(),
            // so suppress finalization.
            GC.SuppressFinalize(this);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
