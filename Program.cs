using System;

namespace MyProject
{
    internal class Program
    {
        //Entery point of the application
        static void Main(string [] args)
        //Body of the Main method
        {
            Console.WriteLine("Enter side A:");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side B:");
            double sideB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Side C is "+Hypotenuse.CalculateHypotenuse(sideA, sideB));
            Console.ReadKey();
        }
    }
}