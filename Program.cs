using System;

namespace MyProject
{
    internal class Program
    {
        //Entery point of the application
        static void Main(string [] args)
        //Body of the Main method
        {
            string playerGuess = "";
            string computerGuess = "";
            bool playAgain = true;
            string userInput = "";

            string [] choices = { "rock", "paper", "scissors" };
            Random rand = new Random();

            while (playAgain)
            {
                computerGuess=choices [rand.Next(0, choices.Length)];
                while (playerGuess!="r"&&playerGuess!="p"&&playerGuess!="s")
                {
                    Console.Write("Enter your choice (rock - r , paper - p, scissors - s): ");
                    playerGuess=Console.ReadLine().ToLower();
                }

                Console.WriteLine($"Computer chose: {computerGuess}");
                if (playerGuess=="r")
                {
                    switch (computerGuess)
                    {
                        case "rock":
                            Console.WriteLine("It's a tie!");
                            break;
                        case "paper":
                            Console.WriteLine("Computer wins!");
                            break;
                        case "scissors":
                            Console.WriteLine("You win!");
                            break;
                    }
                }
                else if (playerGuess=="p")
                {
                    switch (computerGuess)
                    {
                        case "rock":
                            Console.WriteLine("You win!");
                            break;
                        case "paper":
                            Console.WriteLine("It's a tie!");
                            break;
                        case "scissors":
                            Console.WriteLine("Computer wins!");
                            break;
                    }
                }
                else if (playerGuess=="s")
                {
                    switch (computerGuess)
                    {
                        case "rock":
                            Console.WriteLine("Computer wins!");
                            break;
                        case "paper":
                            Console.WriteLine("You win!");
                            break;
                        case "scissors":
                            Console.WriteLine("It's a tie!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }

                while (userInput!="y"&&userInput!="n")
                {
                    Console.Write("Would your like to play again? Y/N ");
                    userInput=Console.ReadLine().ToLower();
                }

                playAgain=(userInput=="y" ? true : false);
                userInput="";
                playerGuess="";

            }

            Console.WriteLine("Thnx for game!!");


            Console.ReadKey();
        }
    }
}
