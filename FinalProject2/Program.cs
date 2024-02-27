using System;

class NumberGuessingGame
{
    static void Main(string[] args)
    {
        // Set the range for the random number
        int minNumber = 1;
        int maxNumber = 100;

        // Generate a random number
        Random random = new Random();
        int targetNumber = random.Next(minNumber, maxNumber + 1);

        // Initialize variables for tracking game state
        int attempts = 0;
        int guess = 0;
        bool guessedCorrectly = false;

        // Welcome message
        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine($"Guess a number between {minNumber} and {maxNumber}.");

        // Main game loop
        while (!guessedCorrectly)
        {
            // Prompt the user to guess the number
            Console.Write("Enter your guess: ");

            // Read user input
            if (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            // Increment the number of attempts
            attempts++;

            // Check if the guess is correct
            if (guess == targetNumber)
            {
                guessedCorrectly = true;
                Console.WriteLine($"Congratulations! You guessed the number {targetNumber} correctly in {attempts} attempts.");
            }
            else
            {
                // Provide a hint
                if (guess < targetNumber)
                {
                    Console.WriteLine("Too low! Try a higher number.");
                }
                else
                {
                    Console.WriteLine("Too high! Try a lower number.");
                }
            }
        }

        // Game over
        Console.WriteLine("Thank you for playing!");
    }
}
