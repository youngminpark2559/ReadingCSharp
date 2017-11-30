using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Update MusicMedia enumeration type.

namespace CarLibrary
{
    // Which type of music player does this car have?
    public enum MusicMedia
    {
        musicCd,
        musicTape,
        musicRadio,
        musicMp3
    }

    // Represents the state of the engine.
    public enum EngineState
    { engineAlive, engineDead }

    // The abstract base class in the hierarchy.
    public abstract class Car
    {
        public string PetName { get; set; }
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }

        protected EngineState egnState = EngineState.engineAlive;
        public EngineState EngineState
        {
            get { return egnState; }
        }
        public abstract void TurboBoost();
        public Car() { }
        public Car(string name, int maxSp, int currSp)
        {
            PetName = name; MaxSpeed = maxSp; CurrentSpeed = currSp;
        }
    }
}