using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StonePaperScissor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] choices = { "stone", "paper,", "scissor" };
            Random random = new Random();
            int userScore = 0 ,ComputerScore = 0, rounds = 0;

            while (rounds < 10)
            {
                Console.WriteLine("Choose Stone,paper,or scissor or type exit to quit the game:");
                string userChoice = Console.ReadLine();

                if (userChoice == "exit")
                {
                    break;
                }
                int randomComputerChoice = random.Next(3);
                string computerChoice = choices[randomComputerChoice];
                Console.WriteLine($"Computer choice:{computerChoice}");

                if (userChoice == computerChoice)
                {
                    Console.WriteLine("Play again");
                }
                else if ((userChoice == "stone" && computerChoice == "scissor")||
                        (userChoice == "paper" && computerChoice == "stone")||
                        (userChoice == "scissor" && computerChoice == "paper"))
                {
                    Console.WriteLine("You won this round");
                    userScore++;
                }
                else
                {
                    Console.WriteLine("Computer won this round");
                    ComputerScore++;
                }
                rounds++;
                Console.WriteLine($"Score :yours{userScore} - Compurer{ComputerScore}");
                Console.WriteLine();
            }
            Console.WriteLine("Game is over");
            if (userScore > ComputerScore)
            {
                Console.WriteLine("You won the game");
            }
            else if(userScore<ComputerScore)
            {
                Console.WriteLine("Computer won the game");
            }
            else
            {
                Console.WriteLine("Its a tie");
            }

        }
    }
}
