using System;

namespace MyProject
{
    internal class Program
    {
        //Entery point of the application
        static void Main(string [] args)
        //Body of the Main method
        {
            int friendsCount = 5;

            // Different ways to increment the value of friendsCount by 1
            friendsCount=friendsCount+1;
            friendsCount+=1;
            friendsCount++;

            // Different ways to decrement the value of friendsCount by 1
            friendsCount=friendsCount-1;
            friendsCount-=1;
            friendsCount--;

            // Different ways to double the value of friendsCount
            friendsCount=friendsCount*2;
            friendsCount*=2;

            // Different ways to halve the value of friendsCount
            friendsCount=friendsCount/2;
            friendsCount /= 2;

            // Different ways to get the remainder when friendsCount is divided by 3
            friendsCount= friendsCount % 4;
            friendsCount %= 3;

            Console.WriteLine(friendsCount);
            Console.ReadKey();
        }
    }
}