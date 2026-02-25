using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_course.Advancedshit.Delegates
{
    public class CAR
    {
            // Internal state data.
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }
            // Is the car alive or dead?
        private bool _carIsDead;
            // Class constructors.
        public CAR() {}
        public CAR(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }
        public delegate void CarEngineHandler(string msgForCaller);
        // 2) Se define la variable que va a guardar el methodo al que apunta
        private CarEngineHandler _listOfHandlers;
        // 3) se agrega el methodo a la lista
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            _listOfHandlers = methodToCall; //monocast para multicast usamos +=
        }
        public void Accelerate(int delta)
            {
            // If this car is "dead," send dead message.
            if (_carIsDead)
            {
                _listOfHandlers?.Invoke("Sorry, this car is dead..."); //methodo.invoke osea llamamos al delegate
            }
            else
            {
                CurrentSpeed += delta;
            // Is this car "almost dead"?
            if (10 == (MaxSpeed - CurrentSpeed))
            {
                _listOfHandlers?.Invoke("Careful buddy! Gonna blow!");
            }
            if (CurrentSpeed >= MaxSpeed)
            {
                _carIsDead = true;
            }
            else
            {
                Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
            }
            }
        
        }
    }
}