using System;

namespace MyProject
{
    internal class Program
    {
        //Entery point of the application
        static void Main(string [] args)
        //Body of the Main method
        {
            //Array has fixed size

            //string [] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            string[] cars = new string[4];

            for (int i = 0; i < cars.Length; i++)
            {
                Console.Write("Enter car name: ");
                cars[i] = Console.ReadLine();
            }

            cars[0] = "Opel";

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine("\n"+cars);
            Console.ReadKey();
        }
    }
}
