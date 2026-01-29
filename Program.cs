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

    abstract class Vehicle
    {
        public int speed;

        abstract public void go();
    }

    class Car:Vehicle 
    {
        public int wheels = 4;
        int  speed =70;
        public override void go()
        {
            Console.WriteLine("Car is going!");
            
        }
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
        int speed = 10;
        public override void go()
        {
            Console.WriteLine("Bike is going!");

        }
    }

    class Boat:Vehicle {

        public int wheels = 0;
        int speed = 100;
        public override void go()
        {
            Console.WriteLine("Boat is going!");

        }
    }

    
}
