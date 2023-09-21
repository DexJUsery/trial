using System;
using System.Globalization;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        int Number = 5;
        int Guess = 1;
        while (Guess != Number )
        {
            Console.WriteLine("What is the magic number?");
            Guess = int.Parse(Console.ReadLine()); 

            if (Number > Guess)
            {
                Console.WriteLine("Higher");
            }
            else if (Number < Guess)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }
        } 
    }
}