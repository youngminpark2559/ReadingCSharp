using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add a Car(class) type.
//c Update Car(class) type. I add a CarEngineHandler(delegate) type. I add a CarEngineHandler(delegate) type field listOfHandlers. I add a method RegisterWithCarEngine() which will be used as a register to regist methods to the CarEngineHandler(delegate) type object's invocation list by assigning method to listOfHandlers field.
//c Add a method Accelerate(). This method will invoke method registered in invocation list of CarEngineHandler(delegate) type object under the correct circumstances like an event such as when carIsDead is true or when CurrentSpeed<=MaxSpeed etc.
//c Update a method RegisterWithCarEngine() by making this method enable to register mulitple method to the CarEngineHandler(delegate) type instance's invocation list.
//c Update a method RegisterWithCarEngine(). I can make delegate multicast methods functionality by using Delegate.Combine(). Overloaded += operator is shorthand for this method. Compiler converts += operator used to register mulitple method to the delegate type instance's invocation list to Combine() when it creates CIL instructions for assembly.
//c Add a method UnRegisterWithCarEngine(). This method removes passed delegate instance pointing to a specific method from the delegate type instance's invocation list.
//c I change listOfHandlers field as from private to public.

namespace CarDelegate
{
    public class Car
    {
        // Internal state data.
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }

        // Is the car alive or dead?
        private bool carIsDead;

        // Class constructors.
        public Car() { }
        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }

        // 1) Define a delegate type.
        public delegate void CarEngineHandler(string msgForCaller);

        // 2) Define a member variable of this delegate.
        //private CarEngineHandler listOfHandlers;
        // Now a public member!
        public CarEngineHandler listOfHandlers;

        // 3) Add registration function for the caller.
        // Now with multicasting support!
        // Note we are now using the += operator, not
        // the assignment operator (=).
        //public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        //{
        //    listOfHandlers += methodToCall;
        //}

        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            if (listOfHandlers == null)
                listOfHandlers = methodToCall;
            else
                Delegate.Combine(listOfHandlers, methodToCall);
        }

        public void UnRegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers -= methodToCall;
        }

        // 4) Implement the Accelerate() method to invoke the delegate's
        //    invocation list under the correct circumstances.
        public void Accelerate(int delta)
        {
            // If this car is "dead," send dead message.
            if (carIsDead)
            {
                if (listOfHandlers != null)
                    listOfHandlers("Sorry, this car is dead...");
            }
            else
            {
                CurrentSpeed += delta;

                // Is this car "almost dead"?
                if (10 == (MaxSpeed - CurrentSpeed)
                    && listOfHandlers != null)
                {
                    listOfHandlers("Careful buddy! Gonna blow!");
                }
                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }
}
