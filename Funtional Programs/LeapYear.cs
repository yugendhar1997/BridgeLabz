using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class LeapYear
    {
        public void CheckLeapyear()
        {
            Console.WriteLine("Enter a 4 digit Year to Check Leap Year or Not");
            int year = Convert.ToInt32(Console.ReadLine());


            while (year < 999 || year > 9999)
            {
                Console.WriteLine("Year must be  4 digits");
                Console.WriteLine("Enter a year in 4 Digits");
                year = Convert.ToInt32(Console.ReadLine());
            }

            if (isLeap(year))
            {
                Console.WriteLine();
                Console.WriteLine(year + " is Leap Year");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(year + " is not Leap Year");
            }

            static bool isLeap(int year)
            {
                return ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0));
            }
        }
    }

}
