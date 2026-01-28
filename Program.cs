using System;

namespace MyProject
{
    internal class Program
    {
        //Entery point of the application
        static void Main(string [] args)
        //Body of the Main method
        {
            //Overloading
            Console.WriteLine(Multiply(2.3, 45.1));
            Console.WriteLine(Multiply(2.3, 45.1, 1.5));

            Console.ReadKey();
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}
