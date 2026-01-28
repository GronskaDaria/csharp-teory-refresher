using System;

namespace MyProject
{
    internal class Program
    {
        //Entery point of the application
        static void Main(string [] args)
        //Body of the Main method
        {
            Console.WriteLine("Enter your name:");
            //Read user input from console
            string name =Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age =int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, " + name.ToUpper() + "! \n You was born in " + (DateTime.Now.Year-age));
            Console.ReadKey();
        }
    }
}