// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructuresProgram
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    /// <summary>
    /// this is Utility class.
    /// </summary>
    public class Utility
    {
        static int[,] arr = new int[10, 25];
        static int col0 = 0, col1 = 0, col2 = 0, col3 = 0, col4 = 0, col5 = 0, col6 = 0, col7 = 0, col8 = 0, col9 = 0;
        /// <summary>
        /// Determines whether the specified number is prime.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns>
        ///   <c>true</c> if the specified n is prime; otherwise, <c>false</c>.
        /// </returns>
        public bool IsPrime(int n)
        {
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    c++;
                }
            }
            if (c == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// method for printing two dimensional matrix.
        /// </summary>
        /// <param name="prime">The prime.</param>
        public void Make2Dmatrix(int prime)
        {
            if (prime > 0 && prime <= 100)
            {
                arr[0, col0] = prime;
                col0++;
            }
            else if (prime > 100 && prime <= 200)
            {
                arr[1, col1] = prime;
                col1++;
            }
            else if (prime > 200 && prime <= 300)
            {
                arr[2, col2] = prime;
                col2++;
            }
            else if (prime > 300 && prime <= 400)
            {
                arr[3, col3] = prime;
                col3++;
            }
            else if (prime > 400 && prime <= 500)
            {
                arr[4, col4] = prime;
                col4++;
            }
            else if (prime > 500 && prime <= 600)
            {
                arr[5, col5] = prime;
                col5++;
            }
            else if (prime > 600 && prime <= 700)
            {
                arr[6, col6] = prime;
                col6++;
            }
            else if (prime > 700 && prime <= 800)
            {
                arr[7, col7] = prime;
                col7++;
            }
            else if (prime > 800 && prime <= 900)
            {
                arr[8, col8] = prime;
                col8++;
            }
            else if (prime > 900 && prime <= 1000)
            {
                arr[9, col9] = prime;
                col9++;
            }
        }

        /// <summary>
        /// Show All the instance.
        /// </summary>
        public void show()
        {
            int i, j;
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 25; j++)
                {
                    Console.Write(" " + arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Get the row number.
        /// </summary>
        /// <param name="prime">The prime.</param>
        /// <returns></returns>
        private int GetRowNum(int prime)
        {
            if (prime > 100 && prime <= 200)
            {
                return 1;
            }
            else if (prime > 200 && prime <= 300)
            {
                return 2;
            }
            else if (prime > 300 && prime <= 400)
            {
                return 3;
            }
            else if (prime > 400 && prime <= 500)
            {
                return 4;
            }
            else if (prime > 500 && prime <= 600)
            {
                return 5;
            }
            else if (prime > 600 && prime <= 700)
            {
                return 6;
            }
            else if (prime > 700 && prime <= 800)
            {
                return 7;
            }
            else if (prime > 800 && prime <= 900)
            {
                return 8;
            }
            else if (prime > 900 && prime <= 1000)
            {
                return 9;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Detects the anagram.
        /// </summary>
        /// <param name="frist">The frist.</param>
        /// <param name="second">The second.</param>
        /// <returns></returns>
        public static bool DetectAnagram(string frist, string second)
        {

            if (frist.Length != second.Length)
            {
                return false;
            }
            else
            {
                char[] ch1 = frist.ToCharArray();
                char[] ch2 = second.ToCharArray();
                Array.Sort(ch1);
                Array.Sort(ch2);
                for (int i = 0; i < ch1.Length; i++)
                {
                    if (ch1[i] != ch2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        /// <summary>
        /// check the Prime number that are palindrome.
        /// </summary>
        /// <param name="palindromeString">The palindrome string.</param>
        /// <returns></returns>
        public Boolean CheckPalindrome(string palindromeString)
        {
            Dqueue deque = new Dqueue();

            char[] str = palindromeString.ToCharArray();

            for (int i = 0; i < str.Length; i++)
                deque.AddFront(str[i]);

            int n = str.Length / 2;
            Boolean flag = false;

            for (int i = 1; i <= n; i++)
            {
                char a, b;
                a = deque.RemoveFront();
                b = deque.RemoveRear();

                if (a != b)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Factorials the specified number.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        public static int Factorial(int n)
        {
            int fact = 1;

            while (n > 0)
            {
                fact = fact * n;
                n--;
            }
            return fact;
        }

        /// <summary>
        /// Calender of the month.
        /// </summary>
        public void CalenderOfMonth()
        {
            Console.WriteLine("Enter the Month");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Year");
            int year = Convert.ToInt32(Console.ReadLine());
            DateTime dt = new DateTime(year, month, 1);
            string DaysInMonth = dt.DayOfWeek.ToString();
            int Daysinmonth = (int)dt.DayOfWeek;
            int totalday = DateTime.DaysInMonth(year, month);
            int[,] calender = new int[6, 7];
            Console.WriteLine("sun\tmon\ttu\twed\tth\tfr\tsa");
            int temp = 1;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i == 0 && j < Daysinmonth)
                        calender[0, j] = Daysinmonth;
                    else
                    {
                        if (temp <= totalday)
                        {
                            calender[i, j] = temp;
                            temp++;
                        }
                    }
                }
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i == 0 && j < Daysinmonth || calender[i, j] == 0)
                    {
                        Console.Write("\t");
                    }
                    else
                    {
                        Console.Write(calender[i, j] + "\t");
                    }
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Determines whether [is leap year] [the specified year].
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>
        ///   <c>true</c> if [is leap year] [the specified year]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsLeapYear(int year)
        {
            if ((year % 4 == 0) || (year % 400 == 0 && year % 100 == 0))
            {
                return true;
            }
            return false;
        }

    }

    /// <summary>
    /// this is the class for hashing Function
    /// </summary>
    public class HashingFunction
    {
        internal int[,] hashvalue = new int[10, 10];
        internal int remainder = new int();
        internal int value;
        public int[,] HashFunction(List<int> list)
        {
            int first = 0, second = 0, third = 0, fourth = 0, fifth = 0, sixth = 0, seventh = 0, eight = 0, ninth = 0, tenth = 0;
            foreach (int number in list)
            {
                if (Remainder(number) == 0)
                {
                    hashvalue[0, first] = number;
                    first++;
                }
                else if (Remainder(number) == 1)
                {
                    hashvalue[1, second] = number;
                    second++;
                }
                else if (Remainder(number) == 2)
                {
                    hashvalue[2, third] = number;
                    third++;
                }
                else if (Remainder(number) == 3)
                {
                    hashvalue[3, fourth] = number;
                    fourth++;
                }
                else if (Remainder(number) == 4)
                {
                    hashvalue[4, fifth] = number;
                    fifth++;
                }
                else if (Remainder(number) == 5)
                {
                    hashvalue[5, sixth] = number;
                    sixth++;
                }
                else if (Remainder(number) == 6)
                {
                    hashvalue[6, seventh] = number;
                    seventh++;
                }
                else if (Remainder(number) == 7)
                {
                    hashvalue[7, eight] = number;
                    eight++;
                }
                else if (Remainder(number) == 8)
                {
                    hashvalue[8, ninth] = number;
                    ninth++;
                }
                else if (Remainder(number) == 9)
                {
                    hashvalue[9, tenth] = number;
                    tenth++;
                }
            }
            return hashvalue;
        }

        /// <summary>
        /// Remainder of the specified number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        public int Remainder(int number)
        {
            while (number > 9)
            {
                this.remainder = number % 10;
                number = number / 10;
            }
            return remainder;
        }

        /// <summary>
        /// Search the specified number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        public int Search(int number)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (hashvalue[i, j] == number)
                    {
                        value = i;
                    }
                }
            }
            return value;
        }
    }
}
