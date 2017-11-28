using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a project SimpleDispose.
//c Add a MyResourceWrapper class and it implements IDisposable. Someone will use this class by instantiating this object and after using done he should invoke Dispose() to immediately clean up unmanaged resources and other contained disposable objects from the managed heap. With this Dispose() of IDisposable, I can clean without using Finalize() consuming time and resource of the system.
//c Some base class libraries which implement IDisposable have alias name for Dispose(). It's Close(). It's identical in their functionality.
//c Dispose() is often used with try catch clauses and Dispose() is located in finally block to ensure object must be cleaned no matter what in try block there is some exception or not.
//c I can use same functionality with try catch finally and Dispose() by using using syntax. using syntax makes the use of try catch finally and Dispose() very simple and convinient. And this using syntax is converted to try catch finally and Dispose() syntax in CIL code after being compiled..

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
            //Console.WriteLine("***** Fun with Dispose *****\n");
            //MyResourceWrapper rw = new MyResourceWrapper();
            //if (rw is IDisposable)
            //    rw.Dispose();


            //Console.WriteLine("***** Fun with Dispose *****\n");
            //MyResourceWrapper rw = new MyResourceWrapper();
            //try
            //{
            //    // Use the members of rw.
            //}

            //finally
            //{
            //    // Always call Dispose(), error or not.
            //    rw.Dispose();
            //}

            Console.WriteLine("***** Fun with Dispose *****\n");
            // Dispose() is called automatically when the
            // using scope exits.
            using (MyResourceWrapper rw = new MyResourceWrapper())
            {
                // Use rw object.
            }


            Console.ReadLine();
        }

        // Assume you have imported
        // the System.IO namespace...
        static void DisposeFileStream()
        {
            FileStream fs = new FileStream("myFile.txt", FileMode.OpenOrCreate);

            // Confusing, to say the least!
            // These method calls do the same thing!
            fs.Close();
            fs.Dispose();
        }
    }
}
