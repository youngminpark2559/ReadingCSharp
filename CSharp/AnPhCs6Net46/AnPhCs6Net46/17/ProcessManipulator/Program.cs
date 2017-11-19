using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Use GetProcesses() static method of Process class, to get a collection of process objects running in local computer. And order by ID of process.
//c Use GetSpecificProcess() method to examine a specific process object by specifying PID.

namespace ProcessManipulator
{
    class Program
    {
        static void ListAllRunningProcesses()
        {
            // Get all the processes on the local machine, ordered by
            // PID.
            var runningProcs =
              from proc in Process.GetProcesses(".") orderby proc.Id select proc;

            // Print out PID and name of each process.
            foreach (var p in runningProcs)
            {
                string info = string.Format("-> PID: {0}\tName: {1}",
                  p.Id, p.ProcessName);
                Console.WriteLine(info);
            }
            Console.WriteLine("************************************\n");
        }


        // If there is no process with the PID of 987, a
        // runtime exception will be thrown.
        static void GetSpecificProcess()
        {
            Process theProc = null;
            try
            {
                theProc = Process.GetProcessById(987);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Processes *****\n");
            //ListAllRunningProcesses();
            GetSpecificProcess();
            Console.ReadLine();
        }
    }
}
