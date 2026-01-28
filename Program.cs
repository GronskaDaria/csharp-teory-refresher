using System;

namespace MyProject
{
    internal class Program
    {
        //Entery point of the application
        static void Main(string [] args)
        //Body of the Main method
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            //else if
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }
            //// Using ternary operator
            //Console.WriteLine(age >= 18 ? "You are eligible to vote." : "You are not eligible to vote.");

            Console.ReadKey();
        }
    }
}