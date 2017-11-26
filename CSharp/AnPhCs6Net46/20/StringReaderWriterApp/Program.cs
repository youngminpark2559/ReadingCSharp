using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a project StringReaderWriterApp. StringWriter and StringReader classes is treating a textual information as a stream of in-memory character. I use StringWriter object to append character-based information to an underlying in-memory buffer by writing a block of string data to a StringWriter object rather than a physical file on the local hard drive.
//c At this mement, I made a textual data in memory, and I copy that textual data in value way and print it on the console window. And I use GetStringBuilder object by invokng StringWriter.GetStringBuilder() method. By using this StringBuilder object, I can insert and remove characters located in the memory by specifying the index numbers flexibly.
//c I make a textual data in a buffer on the memory by using StringWriter object. And I fully copy that textual data and print it. And I instatiate StringReader object with passing entire textual data converted from StringWriter obect type to sting type. And I extract a line one by one from the string.

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

                // Get the internal StringBuilder.
                StringBuilder sb = strWriter.GetStringBuilder();
                sb.Insert(0, "Hey!! ");
                Console.WriteLine("-> {0}", sb.ToString());
                sb.Remove(0, "Hey!! ".Length);
                Console.WriteLine("-> {0}", sb.ToString());
            }

            using (StringWriter strWriter = new StringWriter())
            {
                strWriter.WriteLine("Don't forget Mother's Day this year...");
                Console.WriteLine("Contents of StringWriter:\n{0}", strWriter);

                // Read data from the StringWriter.
                using (StringReader strReader = new StringReader(strWriter.ToString()))
                {
                    string input = null;
                    while ((input = strReader.ReadLine()) != null)
                    {
                        Console.WriteLine($"Read textual data by using StringReader object:\n{input}");
                    }
                }
            }


            Console.ReadLine();
        }


    }
}
