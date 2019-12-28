using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class FlipCoin
    {
        static int tailCount;
        static int headCount;

        public void FlipCoins()
        {
            Console.WriteLine("How many times will the coin be flipped?");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Random random = new Random();

                if (random.NextDouble() < 0.5)
                {
                    headCount++;
                }
                else
                {
                    tailCount++;
                }
            }

            double heads = (double)headCount / number * (100.0);
            double tails = (double)tailCount / number * (100.0);
            Console.WriteLine();
            Console.WriteLine("Percentage Of Heads : " + heads + " %");
            Console.WriteLine("Percentage Of Tails : " + tails + " %");
        }
    }
}
