using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application NullableTypes.
//c Updata Main() by declaring value data type local variables and assigning null to them. It's going to cause compile-time error. But when I declare string(class) data type local variables and assign null to it, that brings no issue.
//c Add a method LocalNullableVariables(). Within this, I declare value type local variables (nullable) and assign null to one of them. But I can't declare reference type as nullable by appending ? symbol because reference type is by default nullable.
//c Add a method LocalNullableVariablesUsingNullable(). Within this, I declare value type local variables (nullable) by using Nullable<T> syntax. This way is actually standard way to declare value type local variables (nullable). ? symbol for this is a shorthand for this one and it's actually converted to Nullable<T> syntax by C# compiler toward the CIL instruction in assembly.
//c Add a class DatabaseReader which contains value type (int, bool) field (nullable) and methods whose return types are value type (int, bool) (nullable).

namespace NullableTypes
{
    class DatabaseReader
    {
        // Nullable data field.
        public int? numericValue = null;
        public bool? boolValue = true;

        // Note the nullable return type.
        public int? GetIntFromDatabase()
        { return numericValue; }
        // Note the nullable return type.
        public bool? GetBoolFromDatabase()
        { return boolValue; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Compiler errors!
            // Value types cannot be set to null!
            //bool myBool = null;
            //int myInt = null;

            // OK! Strings are reference types.
            string myString = null;
        }

        static void LocalNullableVariables()
        {
            // Define some local nullable variables.
            int? nullableInt = 10;
            double? nullableDouble = 3.14;
            bool? nullableBool = null;
            char? nullableChar = 'a';
            int?[] arrayOfNullableInts = new int?[10];

            // Error! Strings are reference types!
            // string? s = "oops";
        }

        static void LocalNullableVariablesUsingNullable()
        {
            // Define some local nullable types using Nullable<T>.
            Nullable<int> nullableInt = 10;
            Nullable<double> nullableDouble = 3.14;
            Nullable<bool> nullableBool = null;
            Nullable<char> nullableChar = 'a';
            Nullable<int>[] arrayOfNullableInts = new Nullable<int>[10];
        }
    }
}
