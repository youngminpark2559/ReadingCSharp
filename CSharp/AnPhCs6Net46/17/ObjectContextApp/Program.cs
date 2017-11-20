using System;
using System.Runtime.Remoting.Contexts; // For Context type.
using System.Threading;  // For Thread type.

//c Add a SportsCar class which is not defined by any special object contextual boundary treatment. This class can generate an context-agile object in an ordinal object context, maybe by default default context. Get a current context object on which this object is allocated. And print name of all this context's properties.

namespace ObjectContextApp
{
    // SportsCar has no special contextual
    // needs and will be loaded into the
    // default context of the AppDomain.
    class SportsCar
    {
        public SportsCar()
        {
            // Get context information and print out context ID.
            Context ctx = Thread.CurrentContext;
            Console.WriteLine("{0} object in context {1}",
              this.ToString(), ctx.ContextID);
            foreach (IContextProperty itfCtxProp in ctx.ContextProperties)
                Console.WriteLine("-> Ctx Prop: {0}", itfCtxProp.Name);
        }
    }


    // SportsCarTS demands to be loaded in
    // a synchronization context.
    [Synchronization]
    class SportsCarTS : ContextBoundObject
    {
        public SportsCarTS()
        {
            // Get context information and print out context ID.
            Context ctx = Thread.CurrentContext;
            Console.WriteLine("{0} object in context {1}",
              this.ToString(), ctx.ContextID);
            foreach (IContextProperty itfCtxProp in ctx.ContextProperties)
                Console.WriteLine("-> Ctx Prop: {0}", itfCtxProp.Name);
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Context *****\n");

            // Objects will display contextual info upon creation.
            SportsCar sport = new SportsCar();
            Console.WriteLine();

            SportsCar sport2 = new SportsCar();
            Console.WriteLine();

            SportsCarTS synchroSport = new SportsCarTS();
            Console.ReadLine();
        }
    }
}
