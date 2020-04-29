using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    // Abstract class
    abstract class Shape
    {
        // class properties
        protected string Name { get; set; }


        // parameterized constructor 
        public Shape(string Name)
        {
            this.Name = Name;
        }



        // class methods 
        /// <summary>
        /// Thin method shows all the information of the Shape class
        /// </summary>
        public virtual void ShowInfo()
        {
            Console.WriteLine($"This is a {Name}");
        }

        // this is an abstract method 
        public abstract double Area();
    }
}
