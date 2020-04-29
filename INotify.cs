using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    // interface 
    interface INotify
    {
        // members 
        // when using interface you can only write the definition of the methods not the implementation 
        // you only implement those methods in the derived class
        void ShowNotifications();
        string GetDate();
    }
}
