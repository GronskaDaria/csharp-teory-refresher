using System;

namespace MyProject
{
    internal class Program
    {
        //Entery point of the application
        static void Main(string [] args)
        //Body of the Main method
        {
            //params keyword allows passing a variable number of arguments to a method
            //The method can accept zero or more arguments of a specified type

            Console.WriteLine("Total price: "+ CheckOut(1,4,5,7,23));


            Console.ReadKey();
        }

        static double CheckOut(params double [] prices)
        {
            double total = 0;
            foreach (double price in prices)
            {
                total += price;
            }
            return total;
        }


    }
}
