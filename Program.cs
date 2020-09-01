using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors_0912020
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;


            bool playAgain = true;

            while (playAgain)
            {

                int scorePlayer = 0;
                int scoreCPU = 0;


                while (scorePlayer < 1 && scoreCPU < 1)
                {


                    Console.WriteLine("pick between Rock, Paper or Scissors: ");
                    inputPlayer = Console.ReadLine();


                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 3);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "Rock";
                            Console.WriteLine("Computer chose Rock");
                            if (inputPlayer == "Rock")
                            {
                                Console.WriteLine("Draw\n\n");
                            }
                            else if (inputPlayer == "Paper")
                            {
                                Console.WriteLine("Player wins!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "Scissors")
                            {
                                Console.WriteLine("CPU won!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "Paper";
                            Console.WriteLine("Computer chose Paper");
                            if (inputPlayer == "Paper")
                            {
                                Console.WriteLine("Draw!!\n\n");
                            }
                            else if (inputPlayer == "Rock")
                            {
                                Console.WriteLine("CPU won that round\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "Scissors")
                            {
                                Console.WriteLine("player wins!!\n\n");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputCPU = "Scissors";
                            Console.WriteLine("Computer chose scissors");
                            if (inputPlayer == "Scissors")
                            {
                                Console.WriteLine("Draw\n\n");
                            }
                            else if (inputPlayer == "Rock")
                            {
                                Console.WriteLine("Player wins!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "Paper")
                            {
                                Console.WriteLine("CPU Wins!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry");
                            break;
                    }

                }
                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player won");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU won");
                }
                else
                {

                }

                Console.WriteLine("Do you want to play again???(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                }


            }
        }
    }
}