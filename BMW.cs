using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    // Derived class
    class BMW : Car
    {
        // class properties
        private int Speed { get; set; }
        private string Name { get; set; } = "BMW M235i";


        // parameterized constructor 
        public BMW(int Wheels, int Seats, int EnginePower , int Speed , string Name):
            base(Wheels, Seats, EnginePower)
        {
            this.Speed = Speed;
            this.Name = Name;
        }



        // class methods 
        /// <summary>
        /// This method shows the model of this BMW
        /// </summary>
        public void Model()
        {
            Console.WriteLine("This BMW is {0}", Name);
        }


        /// <summary>
        /// This method shows all the information that related to the BMW class
        /// </summary>
        public override void ShowInfo()
        {
            Console.WriteLine("This BMW has {0} wheels , {1} seats , engine power of {2} , speed {3} " +
                "and the model is {4}"
                , Wheels, Seats, EnginePower, Speed, Name);
        }
    }
}
