using System;

namespace MyProject
{
    internal class Program
    {
        //Entery point of the application
        static void Main(string [] args)
        //Body of the Main method
        {
            int x;
            int y;
            double result;
            try
            {
                Console.WriteLine("Enter first number: ");
                x=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                y=Convert.ToInt32(Console.ReadLine());
                result=x/y;
                Console.WriteLine("Result is "+result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter ONLY numbers.");
                return;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
                return;
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }

            Console.ReadKey();
        }

    }
}
