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
        public static int TailCount;

        /// <summary>
        /// The head count
        /// </summary>
        public static int HeadCount;

        /// <summary>
        /// Flips the coins.
        /// </summary>
        public static void FlipCoins()
        {
            Console.WriteLine("How many times will the coin be flipped?");
            int number = Convert.ToInt32(Console.ReadLine());

            Utility.FlipCoinPercentage(number);
        }
    }
}
