using System;
using System.Runtime.InteropServices;
using System.Web;

namespace MyProject
{
    class Program
    {
        //Entery point of the application
        static void Main(string [] args)
        //Body of the Main method
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            car.go();

            Console.WriteLine("\n"+boat.speed);
            Console.WriteLine(boat.wheels);
            boat.go();

            Console.WriteLine("\n"+bicycle.speed);
            Console.WriteLine(bicycle.wheels);
            bicycle.go();
           
            Console.ReadKey();
        }

    }

    class Vehicle
    {
        public int speed;

        public void go ()
        {
            Console.WriteLine("This is vehicle is moving!");
        }
    }

    class Car:Vehicle 
    {
        public int wheels = 4;
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }

    class Boat:Vehicle {

        public int wheels = 0;
    }

    
}
