using System;

namespace MyProject
{
    internal class Program
    {
        //Entery point of the application
        static void Main(string [] args)
        //Body of the Main method
        {
            // Create an instance of the Random class. Pseudo-random number generator
            Random random = new Random();
            int randomNumber = random.Next(1, 101); // Generates a random number between 1 and 100
            double randomDouble = random.NextDouble(); // Generates a random double between 0.0 and 1.0

            Console.WriteLine("Random number between 1 and 100: " + randomNumber);
            Console.ReadKey();
        }
    }
}