using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OOP
{
    // derived class
    class Notify : INotify
    {
        // class methods 
        /// <summary>
        /// This method return the date and time of the moment 
        /// </summary>
        /// <returns></returns>
        public string GetDate()
        {
            return DateTime.Now.ToString();
        }


        /// <summary>
        /// This method shows a message and wait for 5 seconds
        /// </summary>
        public void ShowNotifications()
        {
            Console.WriteLine("Your data is loading.... ");
            Thread.Sleep(5000);
        }
    }
}
