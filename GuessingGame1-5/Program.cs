using System;

namespace GuessinGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer;
            string inputCPU;
            int randomInt;

            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {

                    Console.WriteLine("Chose number betveen 1 and 5");
                    inputPlayer = Console.ReadLine();

                    Random random = new Random();

                    randomInt = random.Next(1, 6);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "1";
                            Console.WriteLine("Computer chose 1\n");
                            if (inputPlayer == "1")
                            {
                                Console.WriteLine("Draw \n");
                            }
                            else if (inputPlayer == "2" || inputPlayer == "3" || inputPlayer == "4" || inputPlayer == "5")
                            {
                                Console.WriteLine("Player WINS! \n");
                                scorePlayer++;
                            }
                            break;
                        case 2:
                            inputCPU = "2";
                            Console.WriteLine("Computer chose 2\n");
                            if (inputPlayer == "2")
                            {
                                Console.WriteLine("Draw\n");
                            }
                            else if (inputPlayer == "1")
                            {
                                Console.WriteLine("Computer WINS!\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "3" || inputPlayer == "4" || inputPlayer == "5")
                            {
                                Console.WriteLine("Player WINS!\n");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputCPU = "3";
                            Console.WriteLine("Computer chose 3\n");
                            if (inputPlayer == "3")
                            {
                                Console.WriteLine("Draw!\n");
                            }
                            else if (inputPlayer == "1" || inputPlayer == "2")
                            {
                                Console.WriteLine("Computer WINS!\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "4" || inputPlayer == "5")
                            {
                                Console.WriteLine("Player WINS!\n");
                                scorePlayer++;
                            }
                            break;

                        case 4:
                            inputCPU = "4";
                            Console.WriteLine("Computer chose 4\n");
                            if (inputPlayer == "4")
                            {
                                Console.WriteLine("Draw!\n");
                            }
                            else if (inputPlayer == "1" || inputPlayer == "2" || inputPlayer == "3")
                            {
                                Console.WriteLine("Computer WINS!\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "5")
                            {
                                Console.WriteLine("Player WINS!\n");
                                scorePlayer++;
                            }
                            break;
                        case 5:
                            inputCPU = "5";
                            Console.WriteLine("Computer chose 5\n");
                            if (inputPlayer == "5")
                            {
                                Console.WriteLine("Draw!");
                            }
                            else if (inputPlayer == "1" || inputPlayer == "2" || inputPlayer == "3" || inputPlayer == "4")
                            {
                                Console.WriteLine("Computer WINS!\n");
                                scoreCPU++;
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid entery");
                            break;
                    }

                    Console.WriteLine("\n Score:\tPlayer:\t{0}\tCPU:\t{1}\n", scorePlayer, scoreCPU);

                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player WON!");
                }

                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU WON!");
                }

                Console.WriteLine("Do you want to play again? y / n");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
            }
        }
    }
}
