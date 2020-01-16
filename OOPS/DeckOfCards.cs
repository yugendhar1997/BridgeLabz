using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class DeckOfCards
    {
        public static void Cards()
        {
            string[] suit = { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            Shuffle(rank, 13);
            SuitShuffle(suit, 4);

            Console.WriteLine("Random Cards Are:");
            for (int index = 0; index < 13; index++)
            {
                Console.Write(rank[index] + " ");
            }

            Console.WriteLine("\nSuit Contain");
            for (int index = 0; index < 4; index++)
            {
                Console.Write(suit[index] + " ");
            }
        }


        public static void SuitShuffle(string[] suit, int num)
        {
            for (int index = 0; index < 4; index++)
            {
                Random random = new Random();
                int r = index + random.Next(4 - index);

                string temp = suit[r];
                suit[r] = suit[index];
                suit[index] = temp;
            }
        }
        public static void Shuffle(string[] rank, int num)
        {
            Random random = new Random();

            for (int index = 0; index < num; index++)
            {
                int r = index + random.Next(13 - index);
                string temp = rank[r];
                rank[r] = rank[index];
                rank[index] = temp;
            }
        }
    }
}
