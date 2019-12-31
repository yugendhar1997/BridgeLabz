// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Gambler.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// Starts The Game And Print The Wins 
    /// </summary>
    public class Gambler
    {
        /// <summary>
        /// Gambles this instance.
        /// </summary>
        public static void Gamble()
        {
            Console.WriteLine("Enter Stake Value");
            int stake = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Goal Value");
            int goal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many times should you play the game?");
            int noOfTimes = Convert.ToInt32(Console.ReadLine());

            ////Calling The PlayGame Function
            Utility.PlayGame(stake, goal, noOfTimes);
        }
    }
}
