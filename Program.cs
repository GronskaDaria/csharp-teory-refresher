using System;

namespace MyProject
{
    internal class Program
    {
        //Entery point of the application
        static void Main(string [] args)
        //Body of the Main method
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            //while (string.IsNullOrWhiteSpace(name))
            while (name == "")
            {
                Console.WriteLine("Name cannot be empty. Please enter your name: ");
                name = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}

