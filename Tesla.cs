using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    // Derived class
    class Tesla : Car
    {
        // class properties
        private int Speed { get; set; }
        private string Tank { get; set; }
        private string Name { get; set; }


        // parameterized constructor 
        public Tesla(int Wheels, int Seats, int EnginePower, int Speed, string Tank, string Name):
            base(Wheels, Seats, EnginePower)
        {
            this.Speed = Speed;
            this.Tank = Tank;
            this.Name = Name;
        }


        // class methods 
        /// <summary>
        /// This method shows the model of this Tesla
        /// </summary>
        public void Model()
        {
            Console.WriteLine("This Tesla is {0}", Name);
        }

        /// <summary>
        /// This method shows all the information that related to the Tesla class
        /// </summary>
        public override void ShowInfo()
        {
            Console.WriteLine("This Tesla has {0} wheels , {1} seats , engine power of {2} , speed {3} ," +
                "Tank is {4} and the model is {5}"
                , Wheels, Seats, EnginePower, Speed, Tank, Name);
        }


        /// <summary>
        /// This method takes two parameters and returen the name of the Tesla's engine and the numbers of mirrors
        /// (Note): this method is overloading to the method in the base class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="mirrors"></param>
        public void ShowEngine(string name , int mirrors)
        {
            Console.WriteLine("This Tesla has a {0} engine and {1} mirrors", name, mirrors);
        }



    }
}
