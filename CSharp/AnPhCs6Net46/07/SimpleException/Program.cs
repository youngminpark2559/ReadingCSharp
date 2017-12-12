using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add a class Radio. It has a method TurnOn() functioning depeding on a boolean data type argument.
//c Add a class Car. This Car class has-a Radio class inside of it. The relationship between Car and Radio is Car has-a Radio(containment/delegation model, aggregation).
//c Update a method Main(). I instantiate Car instance with passing 2 arguments. I increase CurrentSpeed property's backing field data by 10 points each iteration by for iteration statement.
//c Update Accelerate(). If CurrentSpeed's backing field data is over MaxSpeed's backing field data, I throw exception with pre defined fortamt of massege composed of string data type literal.
//c Update a method Main(). This time, I(user) use try/catch clause to handle exception which can be occurred in codes. And since the exception is an instance, I can retrieve data from that exception instance.
//c Update a method Main(). I catch an exception and from exception instance I get TargetSite property which returns System.Reflection.MethodBase object. Anf from this System.Reflection.MethodBase instance I retrieve DeclaringType, MemberType informatioin related to this exception.
//c Update a method Main(). I access to StackTrace property of this exception instance to retrieve string data type literal value related to this exception.
//c Update a method Accelerate(). To use HelpLink, I store a URL to this exception instance's HelpLink property's backing field. 
//c Update a method Main(). I retrieve data stored in this instance's HelpLink's backing field.
//c Update a method Accelerate(). I set System.Exception.Data property by storing custom informations into the Data property's backing field.
//c Update a method Main(). I retrieve a Dictionary data type collection from e.Data's backing field. I execute foreach iteration for this collection one by one with printing each item's key and value.
//c Update a method Main(). I use NullReferenceException(class) type instance and try to check if NullReferenceException(class) type is compatable to SystemException(class) type.

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
                    // We need to call the HelpLink property, thus we need to
                    // create a local variable before throwing the Exception object.
                    Exception ex =
                      new Exception(string.Format("{0} has overheated!", PetName));
                    ex.HelpLink = "http://www.CarsRUs.com";
                    // Stuff in custom data regarding the error.
                    ex.Data.Add("TimeStamp", string.Format("The car exploded at {0}", DateTime.Now));
                    ex.Data.Add("Cause", "You have a lead foot.");
                    throw ex;
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

            // TargetSite actually returns a MethodBase object.
            catch (Exception e)
            {
                Console.WriteLine("\n*** Error! ***");
                Console.WriteLine("Member name: {0}", e.TargetSite);
                Console.WriteLine("Class defining member: {0}",
                  e.TargetSite.DeclaringType);
                Console.WriteLine("Member type: {0}", e.TargetSite.MemberType);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
                Console.WriteLine("Stack: {0}", e.StackTrace);
                Console.WriteLine("Help Link: {0}", e.HelpLink);
                Console.WriteLine("\n-> Custom Data:");
                foreach (DictionaryEntry de in e.Data)
                    Console.WriteLine("-> {0}: {1}", de.Key, de.Value);

                // True! NullReferenceException is-a SystemException.
                NullReferenceException nullRefEx = new NullReferenceException();
                Console.WriteLine("NullReferenceException is-a SystemException? : {0}",
                                   nullRefEx is SystemException);
            }
            Console.WriteLine("\n***** Out of exception logic *****");
            Console.ReadLine();
        }
    }
}
