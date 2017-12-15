using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add a method DisplayMessage() taking 3 arguments, returning void.
//c Update a method Main(). I create an Action<>(delegate) type instance pointing to DisplayMessage() and assgin the reference of that instance to actionTarget. And I invoke DisplayMessage() via actionTarget by making CLR invoke Invoke() in sealed Action<> class with passing 3 arguments.
//c Add a method Add taking 2 Int32(struct) data type numerical values, returning Int32(string) data type value.

namespace ActionAndFuncDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Action and Func *****");

            // Use the Action<> delegate to point to DisplayMessage.
            Action<string, ConsoleColor, int> actionTarget =
              new Action<string, ConsoleColor, int>(DisplayMessage);
            actionTarget("Action Message!", ConsoleColor.Yellow, 5);

            Console.ReadLine();
        }

        // This is a target for the Action<> delegate.
        static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            // Set color of console text.
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;

            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }

            // Restore color.
            Console.ForegroundColor = previous;
        }

        // Target for the Func<> delegate.
        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
