using System;

namespace MyProject
{
    internal class Program
    {
        //Entery point of the application
        static void Main(string [] args)
        //Body of the Main method
        {
            Console.Write("Write name: ");
            string name = Console.ReadLine();
            SingHappyBirthday(name);
            SingHappyBirthday(name);
            SingHappyBirthday(name);
            Console.ReadKey();
        }

        static void SingHappyBirthday(string name)
        {
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine($"Happy Birthday dear {name}!");
            Console.WriteLine("Happy Birthday to you!\n");
        }
    }
}
