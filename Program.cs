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
            //polymorphism -> means to "have many forms"

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Vehicle [] vehicles = { car, bicycle, boat };

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }


            Console.ReadKey();
        }

    }

    class Vehicle
    {
        public virtual void Go() { }

    }

    class Car : Vehicle
    {
        public override void Go() {
            Console.WriteLine("The car is going!");
        }
    }

    class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is going!");
        }
    }

    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The boat is going!");
        }

    }


}
