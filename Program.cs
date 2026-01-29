using System;
using System.Runtime.InteropServices;
using System.Web;

namespace MyProject
{
    class Program
    {
        //Entery point of the application
        static void Main(string [] args)
        //Body of the Main method
        {
            //Overloaded constuctors ->  technique to create multiple constructors, 
            //                            with different set of parameters

            Pizza pizza = new Pizza("stuffed crust", "red", "mozzarella", "salami");
            Pizza pizza1 = new Pizza("stuffed crust", "red", "mozzarella");

            Console.ReadKey();
        }

    }

    class Pizza
    {
        string bread;
        string sauce;
        string cheese;
        string topping;

        public Pizza(string bread, string sauce, string cheese, string topping)
        {
            this.bread=bread;
            this.sauce=sauce;
            this.cheese=cheese;
            this.topping=topping;

        }

        public Pizza(string bread, string sauce, string cheese)
        {
            this.bread=bread;
            this.sauce=sauce;
            this.cheese=cheese;
        }

        public Pizza(string bread, string sauce)
        {
            this.bread=bread;
            this.sauce=sauce;
        }

        public Pizza(string bread)
        {
            this.bread=bread;
        }


    }
}
