using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {

            int playerRandomNum;
            int cpuRandomNum;

            int playerPoints = 0;
            int cpuPoints = 0;

            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice!");
                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(700);

                cpuRandomNum = random.Next(1, 7);
                Console.WriteLine("The cpu rolled a " + cpuRandomNum);

                if(playerRandomNum > cpuRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("player wins this round");
                } else if(playerRandomNum < cpuRandomNum)
                {
                    cpuPoints++;
                    Console.WriteLine("cpu wins this round");
                } else
                {
                    Console.WriteLine("you and the cpu rolled the same nuimber, it's a draw!");
                }
                Console.WriteLine("The score is now - Player: " + playerPoints + " CPU: " + cpuPoints + ".");
                Console.WriteLine();


            }

            if(playerPoints > cpuPoints)
            {
                Console.WriteLine("You win!!");
            } else if (playerPoints < cpuPoints)
            {
                Console.WriteLine("The cpu wins!");
            } else
            {
                Console.WriteLine("It's a tie!!!");
            }

            Console.ReadKey();
        }
    }
}
