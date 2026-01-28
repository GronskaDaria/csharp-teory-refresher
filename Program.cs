using System;

namespace MyProject
{
    internal class Program
    {
        //Entery point of the application
        static void Main(string [] args)
        //Body of the Main method
        {
            int x; // Variable declaration
            x = 10; // Variable initialization
            int y = 20; // Combined declaration and initialization 


            int age = 25;
            double height = 1.9;
            string name = "John Doe";
            bool isStudent = true;
            char grade = 'A';

            Console.WriteLine("My name is "+name);
            Console.WriteLine("My age is "+age +" cm");
            Console.WriteLine("My height "+height);
            Console.WriteLine("Am I student? "+ isStudent);
            Console.WriteLine("My test grade is "+ grade);
            Console.ReadKey();
        }
    }
}