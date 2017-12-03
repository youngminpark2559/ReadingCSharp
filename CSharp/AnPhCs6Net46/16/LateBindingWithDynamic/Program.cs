using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

//c Create a class library and a console app to use dynamic type along with other techniques such as reflection, late-binding, dynamic loading. By using dynamic type when I do this kind of task, I can simplify codes especially when I invoke the method with parameters.

namespace LateBindingWithDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            AddWithDynamic();
            AddWithReflection();
        }

        private static void AddWithReflection()
        {
            Assembly asm = Assembly.Load("MathLibrary");
            try
            {
                // Get metadata for the SimpleMath type.
                Type math = asm.GetType("MathLibrary.SimpleMath");

                // Create a SimpleMath on the fly.
                object obj = Activator.CreateInstance(math);

                // Get info for Add.
                MethodInfo mi = math.GetMethod("Add");

                // Invoke method (with parameters).
                object[] args = { 10, 70 };
                Console.WriteLine("Result is: {0}", mi.Invoke(obj, args));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void AddWithDynamic()
        {
            Assembly asm = Assembly.Load("MathLibrary");

            try
            {
                // Get metadata for the SimpleMath type.
                Type math = asm.GetType("MathLibrary.SimpleMath");

                // Create a SimpleMath on the fly.
                dynamic obj = Activator.CreateInstance(math);

                // Note how easily we can now call Add().
                Console.WriteLine("Result is: {0}", obj.Add(10, 70));
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
