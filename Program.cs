using System;

namespace MyProject
{
    internal class Program
    {
        //Entery point of the application
        static void Main(string [] args)
        //Body of the Main method
        {
            double x = 13;


            double y = Math.Max(x,12);
            double z = Math.Pow(x,2);
            double w = Math.Sqrt(x);
            double v = Math.Abs(-24);
            double u = Math.Round(3.45);
            double t = Math.Ceiling(4.14);
            double s = Math.Floor(6.99);

            Console.WriteLine(y);
            Console.WriteLine(w);
            Console.WriteLine(z);
            Console.WriteLine(v);
            Console.WriteLine(u);
            Console.WriteLine(t);
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}