using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

//c Create a project LateBindingApp to examie how to load assembly without a reference, how to retrieve types from that assembly, all of them by using late binding technique.
//c Update CreateUsingLateBinding() to instantiate type loaded by reflection by using Activator.CreateInstance() in late binding way.

namespace LateBindingApp
{
    // This program will load an external library,
    // and create an object using late binding.
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Late Binding *****");
            // Try to load a local copy of CarLibrary.
            Assembly a = null;
            try
            {
                a = Assembly.Load("CarLibrary");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            if (a != null)
                CreateUsingLateBinding(a);

            Console.ReadLine();
        }


        static void CreateUsingLateBinding(Assembly asm)
        {
            try
            {
                // Get metadata for the Minivan type.
                Type miniVan = asm.GetType("CarLibrary.MiniVan");

                // Create the Minivan on the fly.
                object obj = Activator.CreateInstance(miniVan);
                Console.WriteLine("Created a {0} using late binding!", obj);
                // Get info for TurboBoost.
                MethodInfo mi = miniVan.GetMethod("TurboBoost");

                // Invoke method ('null' for no parameters).
                mi.Invoke(obj, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
