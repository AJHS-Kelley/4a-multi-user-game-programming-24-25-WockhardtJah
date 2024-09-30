using System;
class Template {
  static void Main(string[] args)
    {
        // variable to store the player's name
        string playerName = "Test Player"; // Starting value

        // Player Name
        Console.Write("Type your name then press enter:");
        playerName = Console.ReadLine();

        // Declare variables for scores (no initial value assigned)
        int playerScore; // Player's score
        int cpuScore;    // CPU's score

        // Declare variables for player choice and CPU choice (no initial value assigned)
        int playerChoice; // 1 for Rock, 2 for Paper, 3 for Scissors
        int cpuChoice;    // 1 for Rock, 2 for Paper, 3 for Scissors

        // Output rules of the game
        Console.WriteLine($"\nWelcome to Rock, Paper, Scissors {playerName}:):):):):):):):):)!");
        Console.WriteLine("Rules:"); 
        Console.WriteLine("Rock beats Scissors, Scissors beats Paper, and Paper beats Rock.");
        Console.WriteLine("The first player to reach 5 points wins!");

        // scores
        playerScore = 0;
        cpuScore = 0;

        // Game loop
        while (playerScore < 5 && cpuScore < 5)
        {
            Console.WriteLine("\nChoose an option: (1) Rock, (2) Paper, (3) Scissors");
            playerChoice = int.Parse(Console.ReadLine());

            // Randomly generate CPU choice
            Random random = new Random();
            cpuChoice = random.Next(0, 4); // 1, 2, or 3

            // Show choices
            Console.WriteLine($"{playerName} chose: {GetChoiceName(playerChoice)}");
            Console.WriteLine($"CPU chose: {GetChoiceName(cpuChoice)}");

            // choose winner
            if (playerChoice == cpuChoice)
            {
                Console.WriteLine("It's a tie! No points awarded.");
            }
            else if ((playerChoice == 1 && cpuChoice == 2) || // Rock beats Scissors
                     (playerChoice == 2 && cpuChoice == 1) || // Paper beats Rock
                     (playerChoice == 3 && cpuChoice == 1))   // Scissors beats Paper
            {
                Console.WriteLine($"{playerName} wins this round!");
                playerScore++;
            }
            else
            {
                Console.WriteLine("CPU wins this round!");
                cpuScore++;
            }

            // Show scores
            Console.WriteLine($"Scores: {playerName} {playerScore} - CPU {cpuScore}");
        }

        // Choose overall winner
        if (playerScore == 5)
        {
            Console.WriteLine($"\nCongratulations {playerName}, you won the game!");
        }
        else
        {
            Console.WriteLine("\nCPU won the game! Better luck next time.");
        }
    }

    // the name of the choice
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
}
