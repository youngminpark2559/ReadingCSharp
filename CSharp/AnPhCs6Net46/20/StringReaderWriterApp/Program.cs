using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a project StringReaderWriterApp. StringWriter and StringReader classes is treating a textual information as a stream of in-memory character. I use StringWriter object to append character-based information to an underlying in-memory buffer by writing a block of string data to a StringWriter object rather than a physical file on the local hard drive.

namespace StringReaderWriterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with StringWriter / StringReader *****\n");

            // Create a StringWriter and emit character data to memory.
            using (StringWriter strWriter = new StringWriter())
            {
                strWriter.WriteLine("Don't forget Mother's Day this year...");
                // Get a copy of the contents (stored in a string) and dump
                // to console.
                Console.WriteLine("Contents of StringWriter:\n{0}", strWriter);
            }
            Console.ReadLine();
        }


    }
}
