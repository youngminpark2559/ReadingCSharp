using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add a Car(class) type.
//c Update Car(class) type. I add a CarEngineHandler(delegate) type. I add a CarEngineHandler(delegate) type field listOfHandlers. I add a method RegisterWithCarEngine() which will be used as a register to regist methods to the CarEngineHandler(delegate) type object's invocation list by assigning method to listOfHandlers field.

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
        private CarEngineHandler listOfHandlers;

        // 3) Add registration function for the caller.
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers = methodToCall;
        }
    }
}
