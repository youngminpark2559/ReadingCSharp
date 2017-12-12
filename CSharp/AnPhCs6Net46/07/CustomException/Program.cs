using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add a class CarIsDeadException which will play a role of a custom exception. I can derive this class from ApplicationException class or simply Exception class to make this a custom exception. ApplicationException class contains simple constructor and by this class I can specify this exception is application exception not system exception thrown by CLR runtime.
//c Update a method Accelerate(). I use a custom exception by CarIsDeadException rather than a built-in excetion by Exception class. But note that I also can use Exception class in catch clause.

namespace CustomException
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

                    CarIsDeadException ex = new CarIsDeadException(string.Format("{0} has overheated!", PetName), "You have a lead foot", DateTime.Now);
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

    // This custom exception describes the details of the car-is-dead condition.
    // (Remember, you can also simply extend Exception.)
    public class CarIsDeadException : ApplicationException
    {
        private string messageDetails = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadException() { }
        public CarIsDeadException(string message,
          string cause, DateTime time)
        {
            messageDetails = message;
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }

        // Override the Exception.Message property.
        public override string Message
        {
            get
            {
                return string.Format("Car Error Message: {0}", messageDetails);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
