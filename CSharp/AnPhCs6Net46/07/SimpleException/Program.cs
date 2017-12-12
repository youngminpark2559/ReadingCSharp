using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add a class Radio. It has a method TurnOn() functioning depeding on a boolean data type argument.
//c Add a class Car. This Car class has-a Radio class inside of it. The relationship between Car and Radio is Car has-a Radio(containment/delegation model, aggregation).
//c Update a method Main(). I instantiate Car instance with passing 2 arguments. I increase CurrentSpeed property's backing field data by 10 points each iteration by for iteration statement.
//c Update Accelerate(). If CurrentSpeed's backing field data is over MaxSpeed's backing field data, I throw exception with pre defined fortamt of massege composed of string data type literal.
//c Update a method Main(). This time, I(user) use try/catch clause to handle exception which can be occurred in codes. And since the exception is an instance, I can retrieve data from that exception instance.

namespace SimpleException
{
    class Radio
    {
        public void TurnOn(bool on)
        {
            if (on)
                Console.WriteLine("Jamming...");
            else
                Console.WriteLine("Quiet time...");
        }
    }

    class Car
    {
        // Constant for maximum speed.
        public const int MaxSpeed = 100;

        // Car properties.
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        // Is the car still operational?
        private bool carIsDead;

        // A car has-a radio.
        private Radio theMusicBox = new Radio();

        // Constructors.
        public Car() { }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }
        public void CrankTunes(bool state)
        {
            // Delegate request to inner object.
            theMusicBox.TurnOn(state);
        }

        // This time, throw an exception if the user speeds up beyond MaxSpeed.
        public void Accelerate(int delta)
        {
            if (carIsDead)
                Console.WriteLine("{0} is out of order...", PetName);
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed >= MaxSpeed)
                {
                    carIsDead = true;
                    CurrentSpeed = 0;

                    // Use the "throw" keyword to raise an exception.
                    throw new Exception(string.Format("{0} has overheated!", PetName));
                }
                else
                    Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }

    class Program
    {
        // Handle the thrown exception.
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Exception Example *****");
            Console.WriteLine("=> Creating a car and stepping on it!");
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);
            // Speed up past the car's max speed to
            // trigger the exception.
            try
            {
                for (int i = 0; i < 10; i++)
                    myCar.Accelerate(10);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n*** Error! ***");
                Console.WriteLine("Method: {0}", e.TargetSite);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
            }

            // The error has been handled, processing continues with the next statement.
            Console.WriteLine("\n***** Out of exception logic *****");
            Console.ReadLine();
        }
    }
}
