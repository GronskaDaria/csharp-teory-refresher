using System;
using System.Web;

namespace MyProject
{
    internal class Program
    {
        //Entery point of the application
        static void Main(string [] args)
        //Body of the Main method
        {
            // multidemesional array
            //string [] ford = { "Mustang", "F-150", "Explorer" };
            //string [] chevy = { "Corvette", "Camaro", "Silverado" };
            //string [] toyota = { "Corolla", "Camry", "Rav4" };

            string [,] parkingLot = {   {"Mustang", "F-150", "Explorer" },
                                        {"Corvette", "Camaro", "Silverado" },
                                        {"Corolla", "Camry", "Rav4" }
                                    };

            parkingLot [0, 2]="Fusion";

            //foreach (string car in parkingLot)
            //{
            //    Console.WriteLine(car);
            //};

            for (int i = 0; i<parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j<parkingLot.GetLength(1); j++)
                {
                    Console.Write($"{parkingLot [i, j], 12}");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

    }
}
