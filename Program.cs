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

            Vehicle [] race = { car, bicycle, boat };


            Console.ReadKey();
        }

    }

    class Vehicle
    {

    }

    class Car : Vehicle
    {

    }

    class Bicycle : Vehicle
    {

    }

    class Boat : Vehicle
    {


    }


}
