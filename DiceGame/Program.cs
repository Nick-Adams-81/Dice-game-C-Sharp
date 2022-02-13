using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {

            int playerRandomNum;
            int cpuRandomNum;
            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice!");
                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNum);

                cpuRandomNum = random.Next(1, 7);
                Console.WriteLine("The cpu rolled a " + cpuRandomNum);

            }

            Console.ReadKey();
        }
    }
}
