﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add a class Car. I use event keyword to use delegate functionality in conjunction with event functionality.

namespace CarEvents
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

        // This delegate works in conjunction with the
        // Car's events.
        public delegate void CarEngineHandler(string msg);


        // This car can send these events.
        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;


        

        public void Accelerate(int delta)
        {
            // If the car is dead, fire Exploded event.
            if (carIsDead)
            {
                if (Exploded != null)
                    Exploded("Sorry, this car is dead...");
            }
            else
            {
                CurrentSpeed += delta;
                // Almost dead?
                if (10 == MaxSpeed - CurrentSpeed
                  && AboutToBlow != null)
                {
                    AboutToBlow("Careful buddy! Gonna blow!");
                }

                // Still OK!
                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }
}
