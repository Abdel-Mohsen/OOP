using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    // Derived class
    class Mercedes : Car 
    {
        // class properties
        private int Speed { get; set; }
        private string Name { get; set; } = "Mercedes-Benz CLS";


        // parameterized constructor 
        public Mercedes(int Wheels, int Seats, int EnginePower, int Speed, string Name):
            base(Wheels, Seats, EnginePower)
        {
            this.Name = Name;
            this.Speed = Speed;
        }


        // class methods 
        /// <summary>
        /// This method shows the model of this Mercedes
        /// </summary>
        public void Model()
        {
            Console.WriteLine("This Mercedes is {0}", Name);
        }


        /// <summary>
        /// This method shows all the information that related to the Mercedes class
        /// </summary>
        public new void ShowInfo()
        {
            Console.WriteLine("This Mercedes has {0} wheels , {1} seats , engine power of {2} , speed {3} " +
                "and the model is {4}"
                , Wheels, Seats, EnginePower, Speed, Name);
        }


    }
}
