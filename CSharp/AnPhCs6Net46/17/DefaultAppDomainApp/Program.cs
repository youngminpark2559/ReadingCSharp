using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Get a default AppDomain object. Get informations of the default AppDomain.

namespace DefaultAppDomainApp
{
    class Program
    {
        private static void DisplayDADStats()
        {

            // Get access to the AppDomain for the current thread.
            AppDomain defaultAD = AppDomain.CurrentDomain;

            // Print out various stats about this domain.
            Console.WriteLine("Name of this domain: {0}", defaultAD.FriendlyName);
            Console.WriteLine("ID of domain in this process: {0}", defaultAD.Id);
            Console.WriteLine("Is this the default domain?: {0}",
              defaultAD.IsDefaultAppDomain());
            Console.WriteLine("Base directory of this domain: {0}", defaultAD.BaseDirectory);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with the default AppDomain *****\n");
            DisplayDADStats();
            Console.ReadLine();
        }
    }
}
