using System;

namespace MyProject
{
    internal class Program
    {
        //Entery point of the application
        static void Main(string [] args)
        //Body of the Main method
        {
            int magicNumber = new Random().Next(1, 31);
            Console.WriteLine("Welcome to the Magic Number Guessing Game!");
            Console.WriteLine("Try to guess the magic number between 1 and 30.\n");

            int userGuess = 0;
            while (userGuess!=magicNumber)
            {
                Console.Write("Enter your namber: ");
                userGuess = int.Parse(Console.ReadLine());

                Console.WriteLine(userGuess < magicNumber ? "Too low! Try again." : userGuess > magicNumber ? "Too high! Try again." : "Congratulations! You've guessed the magic number!");
            }

            Console.ReadKey();
        }
    }
}

