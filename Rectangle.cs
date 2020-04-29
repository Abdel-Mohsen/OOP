using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    // Derived class
    class Rectangle : Shape
    {
        // class properties
        private double Width { get; set; }
        private double Height { get; set; }

        // parameterized constructor 
        public Rectangle(string Name, double Width, double Height) :base(Name)
        {
            this.Width = Width;
            this.Height = Height;
        }

        // class methods 
        /// <summary>
        /// This method calculate the area of the rectangle and return the result 
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return (Width * Height);
        }


        /// <summary>
        /// This method shows all the information of the Recatangle class
        /// </summary>
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"This Rectangle's area is {Area()}");
        }
    }
}
