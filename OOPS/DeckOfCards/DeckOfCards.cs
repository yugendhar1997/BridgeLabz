﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeckOfCards.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OOPS
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Distribution Of Cards
    /// </summary>
    public class DeckOfCards
    {

        /// <summary>
        /// This Method is used to test the DeckOfCardsProgram class.
        /// </summary>
        public static void PlayGame()
        {
            string[] suit = { "Diamond", "Club", "Heart", "Spade" };
            string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            string[] cards = new string[53];

            int index = 0;
            for (int innerLoop = 0; innerLoop < suit.Length; innerLoop++)
            {
                for (int outerLoop = 0; outerLoop < rank.Length; outerLoop++)
                {
                    cards[index] = suit[innerLoop] + rank[outerLoop];
                    index++;
                }
            }

            DeckOfCards.PrintCards(cards);
        }
        
        /// <summary>
        /// Shuffles the specified cards.
        /// </summary>
        /// <param name="cards">The cards.</param>
        /// <returns></returns>
        private static string[] Shuffle(string[] cards)
        {
            Random random = new Random();
            for (int index = 0; index < 53; index++)
            {
                int rand = random.Next(52 - index);
                string temp = cards[index];
                cards[index] = cards[rand];
                cards[rand] = temp;
            }
            return cards;
        } 
        public static void PrintCards(string[] cards)
        {
            int noOfPlayers = 4;
            int totalCards = cards.Length - 1;
            int cardPerPlayer = totalCards / noOfPlayers;
            string[,] players = new string[noOfPlayers, cardPerPlayer];
            int i = 0; int j = 0; int k = 0;
            while (i < totalCards)
            {
                j = j % noOfPlayers;
                players[j, k] = cards[i];
                ++j; ++i;
                if (j == noOfPlayers) ++k;
            }
            for (int l = 0; l < 4; l++)
            {
                for (int m = 0; m < 9; m++)
                {
                    Console.Write(players[l, m] + "  ");
                }
                Console.WriteLine();
            }
        }

    }
}
