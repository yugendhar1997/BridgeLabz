// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DayOfWeek.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Algorithm_Programs
{
    using System;

    /// <summary>
    /// this is the Program to find the Day of week.
    /// </summary>
    public class DayOfWeek
    {
        /// <summary>
        /// Days this instance.
        /// </summary>
        public static void Days()
        {
            Console.WriteLine("Enter date");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year");
            int year = Convert.ToInt32(Console.ReadLine());

            if (date <= 31 && month <= 12 && year >= 999 && year <= 9999)
            {
                Utility.Daysofweek(date, month, year);
                Console.WriteLine("Enter days");

                int days = Convert.ToInt32(Console.ReadLine());
                if (days == 0)
                {
                    Console.WriteLine("sunday");
                }
                else if (days == 1)
                {
                    Console.WriteLine("monday");
                }
                else if (days == 2)
                {
                    Console.WriteLine("tuesday");
                }
                else if (days == 3)
                {
                    Console.WriteLine("wednesday");
                }
                else if (days == 4)
                {
                    Console.WriteLine("thursady");
                }
                else if (days == 5)
                {
                    Console.WriteLine("friday");
                }
                else if (days == 6)
                {
                    Console.WriteLine("saturday");
                }
            }
        }
    }
}
