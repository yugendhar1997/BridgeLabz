// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FlipCoin.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    ///  Flip The Coin and Find The Percentage
    /// </summary>
    public class FlipCoin
    {
        /// <summary>
        /// The tail count
        /// </summary>
        private static int tailCount;

        /// <summary>
        /// The head count
        /// </summary>
        private static int headCount;

        /// <summary>
        /// Flips the coins.
        /// </summary>
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

            double heads = (double)headCount / number * 100.0;
            double tails = (double)tailCount / number * 100.0;
            Console.WriteLine();
            Console.WriteLine("Percentage Of Heads : " + heads + " %");
            Console.WriteLine("Percentage Of Tails : " + tails + " %");
        }
    }
}
