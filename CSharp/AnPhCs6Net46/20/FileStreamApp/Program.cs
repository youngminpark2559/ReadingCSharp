using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a project FileStreamApp to examine the process of encoding a string to byte array represented in int and write this byte array to a file. And then read the file and decode byte array to string and print that on the console.

namespace FileStreamApp
{
    class Program
    {
        // Don't forget to import the System.Text and System.IO namespaces.
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with FileStreams *****\n");

            // Obtain a FileStream object.
            using (FileStream fStream = File.Open(@"C:\myMessage.dat",
              FileMode.Create))
            {
                // Encode a string as an array of bytes.
                string msg = "Helloo";
                byte[] msgAsByteArray = Encoding.Default.GetBytes(msg);

                //int[] ints =new[] { 0, 7, 12, 3, 9, 30 };
                //byte[] msgAsByteArray = ints.SelectMany(BitConverter.GetBytes).ToArray();
                foreach (var a in msgAsByteArray)
                {
                    Console.WriteLine($"a: {a}");
                }

                



                //Your message as an array of bytes: 72101108108111111

                // Write byte[] to file.
                fStream.Write(msgAsByteArray, 0, msgAsByteArray.Length);

                // Reset internal position of stream.
                fStream.Position = 0;

                // Read the types from file and display to console.
                Console.Write("Your message as an array of bytes: ");
                byte[] bytesFromFile = new byte[msgAsByteArray.Length];
                for (int i = 0; i < msgAsByteArray.Length; i++)
                {
                    bytesFromFile[i] = (byte)fStream.ReadByte();
                    Console.Write(bytesFromFile[i]);
                }



                // Display decoded messages.
                Console.Write("\nDecoded Message: ");
                Console.WriteLine(Encoding.Default.GetString(bytesFromFile));
            }
            Console.ReadLine();
        }
    }
}
