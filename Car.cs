using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    // Base class
    class Car
    {
        // class properties
        protected int Wheels { get; set; }
        protected int Seats { get; set; }
        protected int EnginePower { get; set; }


        // default constructor 
        public Car() { }
        public Car(int Wheels, int Seats, int EnginePower) {
            this.Wheels = Wheels;
            this.EnginePower = EnginePower;
            this.Seats = Seats;
        
        }

        // class methods 
        /// <summary>
        /// This method shows all the information that related to the car class  
        /// </summary>
        public virtual void ShowInfo()
        {
            Console.WriteLine("This car has {0} wheels , {1} seats and the engine power is {2}"
                , Wheels, Seats, EnginePower);
        }


        /// <summary>
        /// This method takes one parameter and return the name of the car's engine  
        /// </summary>
        /// <param name="name"></param>
        public void ShowEngine(string name)
        {
            Console.WriteLine("This car has a {0} engine",name);
        }
    }
}
