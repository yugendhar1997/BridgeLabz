// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// Contains All Static Methods, Called Whenever Required
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Calculates the distance.
        /// </summary>
        public static void CalculateDistance()
        {
            Console.WriteLine("Enter The X Value");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Y value");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Distance is " + Math.Sqrt((x * x) + (y * y)));
        }

        /// <summary>
        /// Finds the roots.
        /// </summary>
        /// <param name="a">The a.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        public static void FindRoots(int a, int b, int c)
        {
            double delta = (b * b) - (4 * a * c);
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            if (delta == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Roots are Real and Equal " + " &\nRoot 1 :" + root1 + "\nRoot 2 :" + root2);
            }
            else if (delta > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Roots are Real and Unequal " + "&\nRoot 1 :" + root1 + "\nRoot 2 :" + root2);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Roots are Imaginary and Unequal " + " &\nRoot 1 :" + root1 + "\nRoot 2 :" + root2);
            }
        }

        /// <summary>
        /// Calculates the wind.
        /// </summary>
        /// <param name="temperature">The temperature.</param>
        /// <param name="speed">The speed.</param>
        public static void CalculateWind(double temperature, double speed)
        {
            double wind = 35.74 + 0.62158 * temperature + (0.4275 * temperature - 35.75 * Math.Pow(speed, 0.16));
            Console.WriteLine();
            Console.WriteLine("Wind Chill : " + wind);
        }

        /// <summary>
        /// Plays the game.
        /// </summary>
        /// <param name="stake">The stake.</param>
        /// <param name="goal">The goal.</param>
        /// <param name="noOfTimes">The no of times.</param>
        public static void PlayGame(int stake, int goal, int noOfTimes)
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
            Console.WriteLine("Percentage Of Games Won  = " + 100.0 * (wins / noOfTimes) + " %");
            Console.WriteLine("Percentage of Games Lost = " + 100.0 * (noOfTimes - wins) / (noOfTimes) + " %");
        }

        /// <summary>
        /// Coupons the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        public static void Coupons(int input)
        {
            for (int i = 1; i <= input; i++)
            {
                Random random = new Random();
                int num = random.Next(100000, 999999);
                Console.WriteLine(i + " : " + num);
            }
        }

        /// <summary>
        /// Checks the power.
        /// </summary>
        /// <param name="power">The power.</param>
        public static void CheckPower(int power)
        {
            int value = 1;

            for (int i = 1; i <= power; i++)
            {
                value = value * 2;
                Console.WriteLine();
                Console.WriteLine(value);
            }
        }

        /// <summary>
        /// Determines whether the specified year is leap.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>
        ///   <c>true</c> if the specified year is leap; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsLeap(int year)
        {
            return ((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0);
        }

        /// <summary>
        /// Harmonics the value.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>Double Number</returns>
        public static double HarmonicValue(double number)
        {
            double value = 0.0;
            for (int i = 1; i < number; i++)
            {
                value = value + (i / number);
            }
            ////returns value of Nth Harmonic
            return value;
        }

        /// <summary>
        /// Factors the specified number.
        /// </summary>
        /// <param name="number">The number.</param>
        public static void Factors(int number)
        {
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    if (IsPrime(i))
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }

        /// <summary>
        /// Determines whether the specified number is prime.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>
        ///   <c>true</c> if the specified number is prime; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Finds the triplets.
        /// </summary>
        /// <param name="array">The array.</param>
        public static void FindTriplets(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length - 1; j++)
                {
                    for (int k = j + 1; k < array.Length - 1; k++)
                    {
                        if (array[i] + array[j] + array[k] == 0)
                        {
                            Console.WriteLine(array[i] + "+" + array[j] + "+" + array[k] + "=" + "0");
                            SumOf_Three_Integers.Count++;
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Total No.Of Pairs Are : " + SumOf_Three_Integers.Count);
        }

        /// <summary>
        /// Flip coin percentage.
        /// </summary>
        /// <param name="number">The number.</param>
        public static void FlipCoinPercentage(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Random random = new Random();

                if (random.NextDouble() < 0.5)
                {
                    FlipCoin.HeadCount++;
                }
                else
                {
                    FlipCoin.TailCount++;
                }
            }

            double heads = (double)FlipCoin.HeadCount / number * 100.0;
            double tails = (double)FlipCoin.TailCount / number * 100.0;
            Console.WriteLine();
            Console.WriteLine("Percentage Of Heads : " + heads + " %");
            Console.WriteLine("Percentage Of Tails : " + tails + " %");
        }
    }
}
