using System;

namespace MyProject
{
    internal class Program
    {
        //Entery point of the application
        static void Main(string [] args)
        //Body of the Main method
        {
            //Nested Loops = Loops inside of loops. 
            Console.Write("How many rows?: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("How many columns?: ");
            int cols = int.Parse(Console.ReadLine());

            Console.Write("What symbol: ");
            string symbol = Console.ReadLine();

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= cols; j++)
                {
                    Console.Write(" "+symbol);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

