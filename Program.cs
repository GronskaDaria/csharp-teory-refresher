using System;

namespace MyProject
{
    internal class Program
    {
        //Entery point of the application
        static void Main(string [] args)
        //Body of the Main method
        {
            double a = 5.35;
            int b = Convert.ToInt32(a);

            int c = 12;
            double d= Convert.ToDouble(c);

            int e = 100;
            string f = Convert.ToString(e);

            string g = "256";
            int h = Convert.ToInt32(g);

            string i = "#";
            char j = Convert.ToChar(i);

            string k = "true";
            bool l = Convert.ToBoolean(k);

            // Implicit casting (automatically done by the compiler)
            int intVar = 10;
            double doubleVar = intVar+0.1;

            Console.WriteLine(doubleVar);
            Console.WriteLine(doubleVar.GetType());
            Console.ReadKey();
        }
    }
}