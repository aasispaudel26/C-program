using System;
namespace randomGuessing;
class Guess
{
    static void Main()
    {
        // Generate a random number between 1 and 10
        Random random = new Random();
        int randomNumber = random.Next(1, 11);

        int userGuess;
        bool guessedCorrectly = false;

        Console.WriteLine("Welcome to the Guessing Game!");
        
        while (!guessedCorrectly)
        {
            Console.Write("Enter your guess (between 1 and 10): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out userGuess))
            {
                if (userGuess >= 1 && userGuess <= 10)
                {
                    if (userGuess == randomNumber)
                    {
                        guessedCorrectly = true;
                        Console.WriteLine("Congratulations! You guessed the correct number!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong guess. Try again!");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 10.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        Console.WriteLine($"The correct number was: {randomNumber}");
    }
}
