using System;
using System.Linq;

namespace CSharpFund_Project_RockPaperScissors_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor background = Console.BackgroundColor;
            ConsoleColor foreground = Console.ForegroundColor;



            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
            string playerMove = Console.ReadLine();

            while (playerMove != "n")
            {
                if (playerMove == "r" || playerMove == "rock")
                {
                    playerMove = Rock;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                else if (playerMove == "p" || playerMove == "paper")
                {
                    playerMove = Paper;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else if (playerMove == "s" || playerMove == "scissors")
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    playerMove = Scissors;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Invalid input. Try Again...");
                    return;
                }

                Random random = new Random();
                int computerChoice = random.Next(1, 4);

                string computerMove = string.Empty;

                switch (computerChoice)
                {
                    case 1:
                        computerMove = Rock;
                        break;
                    case 2:
                        computerMove = Paper;
                        break;
                    case 3:
                        computerMove = Scissors;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Try Again...");
                        return;
                }
                
                Console.WriteLine($"Computer lucky number: {computerMove}.");

                int computerScore = 0;
                int playerScore = 0;

                if (playerMove == computerMove)
                {
                    Console.WriteLine("Draw!");
                }
                else if (playerMove == "Rock" && computerMove == "Scissors")
                {
                    Console.WriteLine("Player wins!");
                    playerScore++;
                }
                else if (playerMove == "Rock" && computerMove == "Paper")
                {
                    Console.WriteLine("Computer wins!");
                    computerScore++;
                }
                else if (playerMove == "Paper" && computerMove == "Rock")
                {
                    Console.WriteLine("Player wins!");
                    playerScore++;
                }
                else if (playerMove == "Paper" && computerMove == "Scissors")
                {
                    Console.WriteLine("Computer wins!");
                    computerScore++;
                }
                else if (playerMove == "Scissors" && computerMove == "Paper")
                {
                    Console.WriteLine("Player wins!");
                    playerScore++;
                }
                else if (playerMove == "Scissors" && computerMove == "Rock")
                {
                    Console.WriteLine("Computer wins!");
                    computerScore++;
                }
                Console.WriteLine();

                Console.WriteLine($@"=============Score Board=============
| Computer score: |  Player score:  |
|                 |                 |
|        {computerScore}        |        {playerScore}        |  
|                 |                 |
|                 |                 |
|_________________|_________________|");

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Would you like to play again?");
                Console.Write("Type [y] If you want to play again or [n] If you want to leave: ");

                playerMove = Console.ReadLine();

                if (playerMove == "y" || playerMove == "yes")
                {
                    Console.WriteLine("Go ahead!");
                }
                else if (playerMove == "n" || playerMove == "no")
                {
                    Console.WriteLine("Bye bye! See ya!");
                    continue;
                }

                playerMove = Console.ReadLine();
            }
            Console.WriteLine();

            Console.WriteLine("Thank you! I hope you enjoyed!");
        }
    }
}
