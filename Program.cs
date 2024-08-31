// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 101); 
        int userGuess = 0;
        int attempts = 0;
        Console.WriteLine("Welcome to the Guess the Number game!");
        Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess what it is?");
        while (userGuess != numberToGuess)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out userGuess))
            {
                attempts++;

                if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
