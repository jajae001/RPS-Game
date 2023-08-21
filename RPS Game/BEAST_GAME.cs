using System.Threading.Tasks.Sources;

namespace RPS_Game
{
    class BEAST_GAME
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCpu;
            int randomInt;
           
            bool killAgain = true;            

           
            while (killAgain) {

                int scorePlayer = 0;
                int scoreCpu = 0;

                Console.WriteLine("YOU HAVE CHOSEN TO CHALLENGE THE BEAST TO A GAME!");
                Console.WriteLine("\n \n Pick ROCK -> R, PAPER --> P , OR SCISSORS -->S");
                Console.WriteLine("\n AND SEAL YOUR DOOM...!");
                while (scorePlayer < 3 && scoreCpu < 3)
                {
                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);


                    Console.WriteLine("\n \n Pick ROCK -> R, PAPER --> P , OR SCISSORS -->S");
                    
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();
                    switch (randomInt)
                    {
                        case 1:
                            inputCpu = "R";
                            Console.WriteLine("Monster Picks ROCK!");
                            if (inputPlayer == "R")
                            {
                                Console.WriteLine("DRAW ...? ...YOU SURVIVE.. FOR NOW");

                            }
                            else if (inputPlayer == "P")
                            {
                                Console.WriteLine("YOU HAVE BLOODIED THE BEAST!... LUCKY..");
                                scorePlayer++;

                            }
                            else if (inputPlayer == "S")
                            {
                                Console.WriteLine("YOU HAVE BEEN BLOODIED, THE BEASTS REJOICES!!");
                                scoreCpu++;

                            }

                            break;
                        case 2:
                            inputCpu = "P";
                            Console.WriteLine("Monster Picks PAPER!");
                            if (inputPlayer == "P")
                            {
                                Console.WriteLine("DRAW ...? ...YOU SURVIVE.. FOR NOW");

                            }
                            else if (inputPlayer == "S")
                            {
                                Console.WriteLine("YOU HAVE BLOODIED THE BEAST!... LUCKY..");
                                scorePlayer++;

                            }
                            else if (inputPlayer == "R")
                            {
                                Console.WriteLine("YOU HAVE BEEN BLOODIED, THE BEASTS REJOICES!!");
                                scoreCpu++;

                            }
                            break;
                        case 3:
                            inputCpu = "S";
                            Console.WriteLine("Monster Picks SCISSORS!");
                            if (inputPlayer == "S")
                            {
                                Console.WriteLine("DRAW ...? ...YOU SURVIVE.. FOR NOW");

                            }
                            else if (inputPlayer == "R")
                            {
                                Console.WriteLine("YOU HAVE BLOODIED THE BEAST!... LUCKY..");
                                scorePlayer++;

                            }
                            else if (inputPlayer == "P")
                            {
                                Console.WriteLine("YOU HAVE BEEN BLOODIED, THE BEASTS REJOICES!!");
                                scoreCpu++;

                            }
                            break;
                        default:
                            Console.WriteLine("\n THE BEAST SEES YOU ATTEMP TO CHEAT!, PLEASE CHOOSE FROM THE LIST.");
                            break;
                    }
                    Console.WriteLine("\n Scores : \tBEAST: \t{0}\tPLAYER:\t{1}", scoreCpu,scorePlayer);

                }

                if (scorePlayer == 3)                {

                    Console.WriteLine("THE BEAST HAS BEEN DESTROYED!");
                }
                else if (scoreCpu == 3)
                {

                    Console.WriteLine("YOU HAVE BEEN DESTROY, THE BEAST HAS BEEN SAITED!!");
                }                

                Console.WriteLine("\n \n \n BAIT THE BEAST AGAIN? Y/N ?");
                string answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "N")
                {
                    killAgain = false;
                }
                else 
                {
                    killAgain = true;
                    Console.Clear();
                }
            }
        }
    }

}

        
        



