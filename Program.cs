using System;

namespace MyProject
{
    internal class Program
    {
        //Entery point of the application
        static void Main(string [] args)
        //Body of the Main method
        {
            string fullName = "Joe Doe";
            string phoneNumber = "123-456-7890";

            string name = fullName.Substring(0, 3);
            string surname = fullName.Substring(4, 3);

            fullName=fullName.ToLower();
            fullName=fullName.ToUpper();

            phoneNumber=phoneNumber.Replace("-", "/");
            fullName=fullName.Insert(0, "Mr.");
            

            Console.WriteLine(name);
            Console.WriteLine(surname);
            Console.WriteLine(fullName);
            Console.WriteLine(phoneNumber);
            Console.ReadKey();
        }
    }
}