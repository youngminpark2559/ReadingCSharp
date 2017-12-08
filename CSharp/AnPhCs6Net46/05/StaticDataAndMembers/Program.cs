﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add a static property InterestRate which is a good alternative for get/set methods, playing same functionality with them.

namespace StaticDataAndMembers
{
    // A simple savings account class.
    class SavingsAccount
    {
        // Instance-level data.
        public double currBalance;

        // A static point of data.
        public static double currInterestRate = 0.04;

        // Notice that our constructor is setting
        // the static currInterestRate value.
        public SavingsAccount(double balance)
        {
            Console.WriteLine("In normal ctor!");
            currInterestRate = 0.04; // This is static data!
            currBalance = balance;
        }

        // A static constructor!
        static SavingsAccount()
        {
            Console.WriteLine("In static ctor!");
            currInterestRate = 0.04;
        }

        // Static members to get/set interest rate.
        public static void SetInterestRate(double newRate)
        {
            Console.WriteLine("SetInterestRate");
            currInterestRate = newRate;
        }

        public static double GetInterestRate()
        { return currInterestRate; }

        // A static property.
        // This is good alternative for above get/set methods.
        public static double InterestRate
        {
            get { return currInterestRate; }
            set { currInterestRate = value; }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Static Data *****\n");

            // Make an account.
            SavingsAccount s1 = new SavingsAccount(50);

            // Print the current interest rate.
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

            // Try to change the interest rate via property.
            SavingsAccount.SetInterestRate(0.08);

            // Make a second account.
            SavingsAccount s2 = new SavingsAccount(100);

            // Should print 0.08...right??
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
            Console.ReadLine();
        }
    }
}
