using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application FunWithArrays.
//c Add SimpleArrays(). In this method, I create 3 length int array and 100 length string array.
//c Update SimpleArrays(). I create 3 length int array and put the values into the array. And I print all value from myInts array source by using foreach looping.
//c Add DeclareImplicitArrays() which uses implicitly typed local variable type by using var keyword for declaration of array.
//c I can't mix data type for each item when especially using var keyword.
//c Add ArrayOfObjects(). Within this method, I declare 4 lenght object data type array. In this array, any data type value item can be in. It's opposite to the restriction when you uses var keyword.
//c Add RectMultidimensionalArray() which uses multidimensional array-rectangular array.
//c Add JaggedMultidimensionalArray() which uses multidimensional array-jagged array.
//c Add PrintArray() which has int type array parameter. In other word, I can pass array as an argument when I invoke the method.
//c Add GetStringArray() which returns string type array.
//c Add PassAndReceiveArrays() which invokes PrintArray() and GetStringArray() with passing int type array and being returned string type array.

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Arrays *****");
            //SimpleArrays();
            ArrayOfObjects();

            Console.ReadLine();
        }


        static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation.");
            // Create and fill an array of 3 Integers
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            // Now print each value.
            foreach (int i in myInts)
                Console.WriteLine(i);
            Console.WriteLine();
        }

        static void DeclareImplicitArrays()
        {
            Console.WriteLine("=> Implicit Array Initialization.");

            // a is really int[].
            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a is a: {0}", a.ToString());

            // b is really double[].
            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b is a: {0}", b.ToString());

            // c is really string[].
            var c = new[] { "hello", null, "world" };
            Console.WriteLine("c is a: {0}", c.ToString());

            // Error! Mixed types!
            //var d = new[] { 1, "one", 2, "two", false };

            Console.WriteLine();
        }

        static void ArrayOfObjects()
        {
            Console.WriteLine("=> Array of Objects.");

            // An array of objects can be anything at all.
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & Void";
            foreach (object obj in myObjects)
            {
                // Print the type and value for each item in array.
                Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
            }
            Console.WriteLine();
        }

        static void RectMultidimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array.");
            // A rectangular MD array.
            int[,] myMatrix;
            myMatrix = new int[3, 4];

            // Populate (3 * 4) array.
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    myMatrix[i, j] = i * j;

            // Print (3 * 4) array.
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 4; j++)
                    Console.Write(myMatrix[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged multidimensional array.");
            // A jagged MD array (i.e., an array of arrays).
            // Here we have an array of 5 different arrays.
            int[][] myJagArray = new int[5][];

            // Create the jagged array.
            for (int i = 0; i < myJagArray.Length; i++)
                myJagArray[i] = new int[i + 7];

            // Print each row (remember, each element is defaulted to zero!).
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                    Console.Write(myJagArray[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PrintArray(int[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
                Console.WriteLine("Item {0} is {1}", i, myInts[i]);
        }

        static string[] GetStringArray()
        {
            string[] theStrings = { "Hello", "from", "GetStringArray" };
            return theStrings;
        }

        static void PassAndReceiveArrays()
        {
            Console.WriteLine("=> Arrays as params and return values.");
            // Pass array as parameter.
            int[] ages = { 20, 22, 23, 0 };
            PrintArray(ages);

            // Get array as return value.
            string[] strs = GetStringArray();
            foreach (string s in strs)
                Console.WriteLine(s);

            Console.WriteLine();
        }
    }
}
