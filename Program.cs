using System;

namespace MyProject
{
    internal class Program
    {
        //Entery point of the application
        static void Main(string [] args)
        //Body of the Main method
        {
            int num1, num2, result;
            bool choseAgain = true;
            bool validResponse = true;
            char option;
            char againOption = ' ';

            Console.WriteLine("---------------------------");
            Console.WriteLine("Calculator program");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Options:");
            Console.WriteLine("\t + : Addition");
            Console.WriteLine("\t - : Subtraction");
            Console.WriteLine("\t * : Multiplication");
            Console.WriteLine("\t / : Division\n");

            Console.Write("Enter first number: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2=Convert.ToInt32(Console.ReadLine());

            while (choseAgain)
            {
                Console.Write ("\nEnter option: ");
                option=Convert.ToChar(Console.ReadLine());
                switch (option)
                {
                    case '+':
                        result=num1+num2;
                        Console.WriteLine("Addition is: "+result);
                        break;
                    case '-':
                        result=num1-num2;
                        Console.WriteLine("Subtraction is: "+result);
                        break;
                    case '*':
                        result=num1*num2;
                        Console.WriteLine("Multiplication is: "+result);
                        break;
                    case '/':
                        if (num2!=0)
                        {
                            result=num1/num2;
                            Console.WriteLine("Division is: "+result);
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid option selected.");
                        break;
                }

                while (validResponse)
                {
                    Console.Write("Do you want to perform another operation? (y/n): ");
                     againOption = Convert.ToChar(Console.ReadLine());
                    validResponse= againOption=='y' || againOption=='n' ? false : true;
                }
                choseAgain=againOption=='y' ? true : false;
                againOption=' ';
                validResponse=true;
            }


            Console.ReadKey();
        }
    }
}
