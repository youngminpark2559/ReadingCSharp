using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

//c Create a project MyTypeViewer to examine the reflection.

namespace MyTypeViewer
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        // Display method names of type.
        static void ListMethods(Type t)
        {
            Console.WriteLine("***** Methods *****");
            MethodInfo[] mi = t.GetMethods();
            foreach (MethodInfo m in mi)
                Console.WriteLine("->{0}", m.Name);
            Console.WriteLine();
        }

        ////Use LINQ
        //static void ListMethods(Type t)
        //{
        //    Console.WriteLine("***** Methods *****");
        //    var methodNames = from n in t.GetMethods() select n.Name;
        //    foreach (var name in methodNames)
        //        Console.WriteLine("->{0}", name);
        //    Console.WriteLine();
        //}
    }
}
