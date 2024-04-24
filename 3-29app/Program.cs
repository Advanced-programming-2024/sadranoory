using System;

class Program
{
    static void Main()
    {
        int player1Score = 0;
        int player2Score = 0;

        Random random = new Random();

        for (int round = 1; round <= 5; round++)
        {
            Console.WriteLine($"Round {round}");

            int player1Choice = GetPlayerChoice();
            int player2Choice = GetPlayerChoice();

            Console.WriteLine($"Player 1 chooses: {player1Choice}");
            Console.WriteLine($"Player 2 chooses: {player2Choice}");

            if (player1Choice == player2Choice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((player1Choice == 1 && player2Choice == 3) ||
                     (player1Choice == 2 && player2Choice == 1) ||
                     (player1Choice == 3 && player2Choice == 2))
            {
                Console.WriteLine("Player 1 wins this round!");
                player1Score++;
            }
            else
            {
                Console.WriteLine("Player 2 wins this round!");
                player2Score++;
            }

            Console.WriteLine();
        }

        if (player1Score > player2Score)
        {
            Console.WriteLine("Player 1 wins the game!");
        }
        else if (player2Score > player1Score)
        {
            Console.WriteLine("Player 2 wins the game!");
        }
        else
        {
            Console.WriteLine("It's a tie in the game!");
        }
    }

    static int GetPlayerChoice()
    {
        while (true)
        {
            Console.Write("Enter your choice (1 for rock, 2 for paper, 3 for scissors): ");
            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 3)
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
            }
        }
    }
}
