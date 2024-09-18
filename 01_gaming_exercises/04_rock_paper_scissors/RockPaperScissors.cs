using System;
class RockPaperScissors {
  static void Main() {
    
  }
} {
  static void Main(string[] args)
    {
        // Declare and assign a variable to store the player's name
        string playerName = "Test Player"; // Starting value

        // Allow player to input their name
        Console.Write("Enter your name: ");
        playerName = Console.ReadLine();

        // Declare variables for scores (no initial value assigned)
        int playerScore; // Player's score
        int cpuScore;    // CPU's score

        // Declare variables for player choice and CPU choice (no initial value assigned)
        int playerChoice; // 0 for Rock, 1 for Paper, 2 for Scissors
        int cpuChoice;    // 0 for Rock, 1 for Paper, 2 for Scissors

        // Output rules of the game
        Console.WriteLine("\nWelcome to Rock, Paper, Scissors!");
        Console.WriteLine("Rules:");
        Console.WriteLine("Rock beats Scissors, Scissors beats Paper, and Paper beats Rock.");
        Console.WriteLine("The first player to reach 5 points wins!");

        // Initialize scores
        playerScore = 0;
        cpuScore = 0;

        // Game loop
        while (playerScore < 5 && cpuScore < 5)
        {
            Console.WriteLine("\nChoose an option: (0) Rock, (1) Paper, (2) Scissors");
            playerChoice = int.Parse(Console.ReadLine());

            // Randomly generate CPU choice
            Random random = new Random();
            cpuChoice = random.Next(0, 3); // 0, 1, or 2

            // Display choices
            Console.WriteLine($"{playerName} chose: {GetChoiceName(playerChoice)}");
            Console.WriteLine($"CPU chose: {GetChoiceName(cpuChoice)}");

            // Determine winner
            if (playerChoice == cpuChoice)
            {
                Console.WriteLine("It's a tie! No points awarded.");
            }
            else if ((playerChoice == 0 && cpuChoice == 2) || // Rock beats Scissors
                     (playerChoice == 1 && cpuChoice == 0) || // Paper beats Rock
                     (playerChoice == 2 && cpuChoice == 1))   // Scissors beats Paper
            {
                Console.WriteLine($"{playerName} wins this round!");
                playerScore++;
            }
            else
            {
                Console.WriteLine("CPU wins this round!");
                cpuScore++;
            }

            // Display scores
            Console.WriteLine($"Scores: {playerName} {playerScore} - CPU {cpuScore}");
        }

        // Determine overall winner
        if (playerScore == 5)
        {
            Console.WriteLine($"\nCongratulations {playerName}, you won the game!");
        }
        else
        {
            Console.WriteLine("\nCPU won the game! Better luck next time.");
        }
    }

    // Method to get the name of the choice
    static string GetChoiceName(int choice)
    {
        switch (choice)
        {
            case 0: return "Rock";
            case 1: return "Paper";
            case 2: return "Scissors";
            default: return "Invalid choice";
        }
    }
