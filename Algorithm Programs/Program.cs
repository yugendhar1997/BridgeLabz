// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Algorithm_Programs
{
    using System;

    /// <summary>
    /// Run Total Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
       public static void Main(string[] args)
        {
            //// To Perform Test Cases atleast once but in this case created infinite loop
            while (true) 
            { 
                Console.WriteLine();
                Console.WriteLine("Press 1  : Vending Machine");
                Console.WriteLine("Press 2  : Day Of Week");
                Console.WriteLine("Press 3  : Temperature Convertion");
                Console.WriteLine("Press 4  : Monthly Payment");
                Console.WriteLine("Press 5  : Sqrt Newtons Method");
                Console.WriteLine("Press 6  : Permutations Of a String");
                Console.WriteLine("Press 7  : Binary Search The Word From Word List");
                Console.WriteLine("Press 8  : Insertion Sort");
                Console.WriteLine("Press 9  : Bubble Sort");
                Console.WriteLine("Press 10 : Merge Sort");
                Console.WriteLine("Press 11 : An Anagram Detection");
                Console.WriteLine("Press 12 : Prime Numbers b/w Range");
                Console.WriteLine("Press 13 : Guessing The Number");
                Console.WriteLine("Press 14 : Decimal Convertion ");

                int press = Convert.ToInt32(Console.ReadLine());
                switch (press)
                {
                    case 1:
                        VendingMachine.CalculateNotes();
                        break;

                    case 2:
                        DayOfWeek.Days();
                        break;

                    case 3:
                        TemperatureConvertion.Conversion();
                        break;

                    case 4:
                        MonthlyPayment.CalculatePayment();
                        break;

                    case 5:
                        SqrtNewtonMethod.NewtonsMethod();
                        break;

                    case 7:
                        Binary_Search_The_Word.Search();
                        break;

                    case 8:
                        Insertion_Sort.Sort();
                        break;

                    case 9:
                        Bubble_Sort.PerformBubbleSort();
                        break;

                    case 11:
                        Anagram.DetectAnagram();
                        break;

                    case 12:
                        Prime_Numbers.CheckPrime();
                        break;

                    case 13:
                        FindNumber.Find();
                        break;

                    case 14:
                        DecimalToBinary.DecimalConversion();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } 
        }
    }
}
