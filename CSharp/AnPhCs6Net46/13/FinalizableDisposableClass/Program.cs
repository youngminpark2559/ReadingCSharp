using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a project FinalizableDisposableClass. A MyResourceWrapper class will use both of ways to clean object from the unmanaged heap. IDisposable and finalizer.
//c Use IDisposable and finalizer by helper method.

namespace FinalizableDisposableClass
{
    class MyResourceWrapper : IDisposable
    {
        // Used to determine if Dispose()
        // has already been called.
        private bool disposed = false;

        public void Dispose()
        {
            // Call our helper method.
            // Specifying "true" signifies that
            // the object user triggered the cleanup.
            CleanUp(true);

            // Now suppress finalization.
            GC.SuppressFinalize(this);
        }

        private void CleanUp(bool disposing)
        {
            // Be sure we have not already been disposed!
            if (!this.disposed)
            {
                // If disposing equals true, dispose all
                // managed resources.
                if (disposing)
                {
                    // Dispose managed resources.
                }
                // Clean up unmanaged resources here.
            }
            disposed = true;
        }
        ~MyResourceWrapper()
        {
            // Call our helper method.
            // Specifying "false" signifies that
            // the GC triggered the cleanup.
            CleanUp(false);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
