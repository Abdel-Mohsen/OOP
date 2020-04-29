using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(4,5,1200);
            Mercedes mercedes = new Mercedes(4,5,4000,600, "Mercedes-Benz CLS");
            BMW bMW = new BMW(4,5,3800,560, "BMW M235i");
            Tesla tesla = new Tesla(4,5,4000,650,"Electric Charge","Tesla S");

            // base class reference variable that points to derived class object 
            Car car2 = new Tesla(4, 5, 4000, 650, "Electric Charge", "Tesla S");
            Car car3 = new BMW(4, 5, 3800, 560, "BMW M235i");
            Car car4 = new Mercedes(4, 5, 4000, 600, "Mercedes-Benz CLS");


            car.ShowInfo();
            // dummy engine names 
            car.ShowEngine("Mobile Z");
            Console.WriteLine("____________________________________________________________________________");
            bMW.ShowInfo();
            bMW.Model();
            // dummy  engine names 
            bMW.ShowEngine("Andrw 5");
            Console.WriteLine("____________________________________________________________________________");
            // dummy engine names 
            mercedes.ShowEngine("Say SO");
            mercedes.ShowInfo();
            mercedes.Model();
            Console.WriteLine("____________________________________________________________________________");
            // dummy engine names 
            tesla.ShowEngine("TS", 4);
            tesla.ShowEngine("Red R");
            tesla.Model();
            tesla.ShowInfo();
            Console.WriteLine("____________________________________________________________________________");
            // method overriding
            car2.ShowInfo();
            // method overriding
            car3.ShowInfo();
            // method hiding
            car4.ShowInfo();
            Console.WriteLine("____________________________________________________________________________");
            Console.WriteLine("\n");

            // you can't instantiate object from an abstract class 
            //Shape shape = new Shape();  ::: Flag Error 

            // base class reference variable that points to derived class object 
            Shape shapes = new Rectangle("Rectangle", 10, 8);
            shapes.Area();
            shapes.ShowInfo();

            Console.WriteLine("\n");

            Notify notify = new Notify();
            notify.ShowNotifications();
            Console.WriteLine(notify.GetDate());

            Console.Read();

        }
    }
}
