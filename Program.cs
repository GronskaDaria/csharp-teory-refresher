using System;

namespace MyProject
{
    internal class Program
    {
        //Entery point of the application
        static void Main(string [] args)
        //Body of the Main method
        {
            Console.WriteLine("What's the temperature outside: (C)");
            double celsius = Convert.ToDouble(Console.ReadLine());

            if (celsius>=10 && celsius<25)
            {
                Console.WriteLine("It's warm outside!");
            }
            else if(celsius<-50 || celsius>50)
            {
                Console.WriteLine("DON'T GO OUTSIDE!!!!");
            }
                Console.ReadKey();
        }
    }
}

