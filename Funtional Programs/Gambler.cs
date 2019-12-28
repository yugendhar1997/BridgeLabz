using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Gambler
    {
        public void Gamble()
        {
            Console.WriteLine("Enter Stake Value");
            int stake = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Goal Value");
            int goal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many times should you play the game?");
            int noOfTimes = Convert.ToInt32(Console.ReadLine());

            PlayGame(stake, goal, noOfTimes);
        }

        public void PlayGame(int stake, int goal, int noOfTimes)
        {
            int wins = 0;
            int bets = 0;

            for (int i = 1; i < noOfTimes; i++)
            {
                int cash = stake;

                while (cash > 0 && cash < goal)
                {
                    bets++;

                    Random random = new Random();
                    if (random.NextDouble() < 0.5)
                    {
                        cash++;
                    }
                    else
                    {
                        cash--;
                    }
                }

                if (cash == goal)
                {
                    wins++;
                }
            }

            Console.WriteLine();
            Console.WriteLine(wins + " Wins Of " + noOfTimes + " times played");
            Console.WriteLine("Percentage Of Games Won  = " + 100.0 * wins / noOfTimes + " %");
            Console.WriteLine("Percentage of Games Lost = " + 100.0 * (noOfTimes - wins) / noOfTimes + " %");
        }
    }
}
