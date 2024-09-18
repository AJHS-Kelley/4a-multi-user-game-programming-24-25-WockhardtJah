using System;
class Template {
  static void Main() {
class Program
{
    static void Main(string[] args)
    {
        // Maximum number of guesses
        const int maxGuesses = 5;

        // Generate a random secret number between 1 and 100
        Random random = new Random();
        int secretNumber = random.Next(1, 101);
        
        int numberOfGuesses = 0;
        bool hasGuessedCorrectly = false;

        Console.WriteLine("Welcome to the Guessing Game!");
        Console.WriteLine($"You have {maxGuesses} attempts to guess the secret number between 1 and 100.");

        while (numberOfGuesses < maxGuesses && !hasGuessedCorrectly)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();

            // Validate input
            if (int.TryParse(input, out int userGuess))
            {
                numberOfGuesses++;

                if (userGuess < secretNumber)
                {
                    Console.WriteLine("Your guess is too low.");
                }
                else if (userGuess > secretNumber)
                {
                    Console.WriteLine("Your guess is too high.");
                }
                else
                {
                    hasGuessedCorrectly = true;
                    Console.WriteLine("Congratulations! You've guessed the correct number!");
                }
            }
            else
  }
}