// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Programs.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Run Total Program
    /// </summary>
    public class Programs
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            //// Using Do While , Created Infinite Loop
            do
            {
                Console.WriteLine();
                Console.WriteLine("Press 1  : User Name Replace");
                Console.WriteLine("Press 2  : Flip Coin");
                Console.WriteLine("Press 3  : Leap Year");
                Console.WriteLine("Press 4  : Power Of 2");
                Console.WriteLine("Press 5  : Harmonic Number");
                Console.WriteLine("Press 6  : Prime Factors");
                Console.WriteLine("Press 7  : 2D Array");
                Console.WriteLine("Press 8  : Sum Of Three Integers");
                Console.WriteLine("Press 9  : Distance");
                Console.WriteLine("Press 10 : Quadratic Equation Roots");
                Console.WriteLine("Press 11 : Wind Chill");
                Console.WriteLine("Press 12 : Gambler");
                Console.WriteLine("Press 13 : Coupon Numbers");
                Console.WriteLine("Press 14 : StopWatch Program");
                Console.WriteLine("Press 15 : Tic-Tac-Toe Game");

                int press = Convert.ToInt32(Console.ReadLine());

                switch (press)
                {
                    case 1:
                        ReplaceString replaceString = new ReplaceString();
                        replaceString.ReplaceStrings();
                        break;

                    case 2:
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.FlipCoins();
                        break;

                    case 3:
                        LeapYear leapYear = new LeapYear();
                        leapYear.CheckLeapyear();
                        break;

                    case 4:
                        PowerOf2 power = new PowerOf2();
                        power.PowerOfTwo();
                        break;

                    case 5:
                        HarmonicNumber harmonicNumber = new HarmonicNumber();
                        harmonicNumber.FindHarmonicNumber();
                        break;

                    case 6:
                        PrimeFactors primeFactors = new PrimeFactors();
                        primeFactors.PrimeFactor();
                        break;

                    case 7:
                        break;

                    case 8:
                        SumOf_Three_Integers sumOf_Three_Integers = new SumOf_Three_Integers();
                        sumOf_Three_Integers.SumOfNumbers();
                        break;

                    case 9:
                        Distance distance = new Distance();
                        distance.FindDistance();
                        break;

                    case 10:
                        Quadratic quadratic = new Quadratic();
                        quadratic.Quadratics();
                        break;

                    case 11:
                        WindChill windChill = new WindChill();
                        windChill.FindWindChill();
                        break;

                    case 12:
                        Gambler gambler = new Gambler();
                        gambler.Gamble();
                        break;

                    case 13:
                        Coupon_Numbers coupon_Numbers = new Coupon_Numbers();
                        coupon_Numbers.GenerateCoupons();
                        break;

                    case 14:
                        StopWatchTime stopWatchTime = new StopWatchTime();
                        stopWatchTime.Watch();
                        break;

                    case 15:
                        break;
                }
            } 
            while (true);
        }
    }
}
