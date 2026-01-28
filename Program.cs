using System;

namespace MyProject
{
    internal class Program
    {
        //Entery point of the application
        static void Main(string [] args)
        //Body of the Main method
        {
            Console.WriteLine("What day is it today?");
            string day = Console.ReadLine();

            switch (day.ToLower())
            {
                case "monday":
                    Console.WriteLine("Today is Monday.");
                    break;
                case "tuesday":
                    Console.WriteLine("Today is Tuesday.");
                    break;
                case "wednesday":
                    Console.WriteLine("Today is Wednesday.");
                    break;
                case "thursday":
                    Console.WriteLine("Today is Thursday.");
                    break;
                case "friday":
                    Console.WriteLine("Today is Friday.");
                    break;
                case "saturday":
                    Console.WriteLine("Today is Saturday.");
                    break;
                case "sunday":
                    Console.WriteLine("Today is Sunday.");
                    break;
                default:
                    Console.WriteLine("Invalid day entered.");
                    break;
            }
            Console.ReadKey();
        }
    }
}

