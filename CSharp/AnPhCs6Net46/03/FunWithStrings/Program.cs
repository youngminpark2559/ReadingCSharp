using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add StringConcatenation() to examine string concatenation.
//c Update StringConcatenation() to use directly String.Concat() to concatenate 2 string type values instead of using + operator which is finally converted to String.Concat() by C# compiler.

namespace FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String functionality:");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contains the letter y?: {0}",
              firstName.Contains("y"));
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));
            Console.WriteLine();
        }


        static void StringConcatenation()
        {
            Console.WriteLine("=> String concatenation:");
            string s1 = "Programming the ";
            string s2 = "PsychoDrill (PTP)";
            //string s3 = s1 + s2;
            string s3 = String.Concat(s1, s2);
            Console.WriteLine(s3);
            Console.WriteLine();
        }



    }
}
