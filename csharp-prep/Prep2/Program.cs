using System;
using System.IO.Pipes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string Number = Console.ReadLine();
        int userInput = int.Parse(Number);

        string letter = "";

        if (userInput >= 90)
        {
            letter = "A";
        }
        else if (userInput >= 80)
        {
            letter = "B";
        }
        else if (userInput >= 70)
        {
            letter = "C";
        }
        else if (userInput >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (userInput >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else 
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}