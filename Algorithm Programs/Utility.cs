// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Algorithm_Programs
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Contains All Methods, Called Whenever Required
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Finds the notes.
        /// </summary>
        /// <param name="amount">The amount.</param>
        /// <param name="notes">The notes.</param>
        public static void FindNotes(int amount, int[] notes)
        {
            int i = 0;
            int total = 0;
            while (amount != 0)
            {
                if (amount / notes[i] != 0)
                {
                    ////calculate Distinct Notes
                    total += amount / notes[i];
                    Console.WriteLine(notes[i] + " rs notes :" + (amount / notes[i]));
                    amount = amount % notes[i];
                }

                i++;
            }

            if (amount == 0)
            {
                Console.WriteLine("total notes :" + total);
            }
        }

        /// <summary>
        /// Payments the specified principle amount.
        /// </summary>
        /// <param name="principleAmount">The principle amount.</param>
        /// <param name="years">The years.</param>
        /// <param name="rateOfInterest">The rate of interest.</param>
        public static void Payment(double principleAmount, double years, double rateOfInterest)
        {
            double n = 12 * years;
            double r = rateOfInterest / (12 * 100);

            double payment = (principleAmount * r) / (1 - Math.Pow(1 + r, -n));
            Console.WriteLine("Monthly Payment Rs :" + payment + "/-");
        }

        /// <summary>
        /// Bubble the sorting.
        /// </summary>
        public static void BubbleSorting()
        {
            try
            {
                Console.WriteLine("Enter String");
                string str = Console.ReadLine();
                string[] arr = str.Split(' ');

                for (int i = 0; i <= arr.Length; i++)
                {
                    for (int j = 1; j < arr.Length - 1; j++)
                    {
                        if (arr[j - 1].CompareTo(arr[j]) > 0)
                        {
                            string temp = arr[j - 1];
                            arr[j - 1] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }

                foreach (string a in arr)
                {
                    Console.WriteLine(a);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Insertions the sorting integer.
        /// </summary>
        /// <exception cref="Exception">Exception handled</exception>
        public static void InsertionSortingInteger()
        {
            try
            {
                Console.WriteLine("Enter the size of integer");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[size];
                Console.WriteLine("Enter Number");
                for (int i = 0; i < size; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 1; i < size; i++)

                {
                    int key = arr[i];
                    int j = i - 1;

                    while (j >= 0 && arr[j] > key)
                    {
                        arr[j + 1] = arr[j];
                        j = j - 1;
                    }

                    arr[j + 1] = key;
                }

                foreach (int a in arr)
                {
                    Console.WriteLine(a);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Divide the array.
        /// </summary>
        /// <param name="lower">The lower.</param>
        /// <param name="higher">The higher.</param>
        /// <param name="array">The array.</param>
        /// <param name="a">The a.</param>
        static public void MainMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }
            while (left <= eol)
            {

                temp[pos++] = numbers[left++];
            }
            while (mid <= right)
            {
                temp[pos++] = numbers[mid++];
            }

            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        static public void SortMerge(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(numbers, left, mid);
                SortMerge(numbers, (mid + 1), right);
                MainMerge(numbers, left, (mid + 1), right);
            }
        }

        /// <summary>
        /// Performs the anagram.
        /// </summary>
        /// <param name="string1">The string1.</param>
        /// <param name="string2">The string2.</param>
        public static void PerformAnagram(string string1, string string2)
        {
            char[] charArray1 = string1.ToCharArray();
            char[] charArray2 = string2.ToCharArray();

            Array.Sort(charArray1);
            Array.Sort(charArray2);

            string newword1 = new string(charArray1);
            string newword2 = new string(charArray2);

            if (newword1 == newword2)
            {
                Console.WriteLine("Both The Strings Are Anagram");
            }
            else
            {
                Console.WriteLine("Both The Strings Are Not Anagram");
            }
        }

        /// <summary>
        /// Finds your number.
        /// </summary>
        public static void FindYourNum()
        {
            Console.WriteLine("Enter range of the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] numberlist = new int[num];
            int start = 0;
            int end = num - 1;
            int mid = (start + end) / 2;

            for (int i = 0; i < num; i++)
            {
                numberlist[i] = i;
            }

            while (start <= end)
            {
                mid = (start + end) / 2;
                Console.WriteLine("\n is this your num" + numberlist[mid] + "\n Y OR N");
                char isnum = Console.ReadLine()[0];
                if (isnum == 'Y')
                {
                    Console.WriteLine("great");
                    break;
                }
                else
                {
                    Console.WriteLine("\n is Your num greater than" + numberlist[mid] + "\n Y OR N");
                    char decision = Console.ReadLine()[0];
                    if (decision == 'Y')
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
            }
        }

        /// <summary>
        /// String the search.
        /// </summary>
        public static void StringBinarySearch()
        {
            try
            {
                Console.WriteLine("Enter the string");
                string str = Console.ReadLine();
                string[] arr = str.Split(' ');
                Array.Sort(arr);
                Console.WriteLine("Enter word to be search");
                string word = Console.ReadLine();

                int start = 0;
                int end = arr.Length - 1;
                int mid;

                while (start <= end)
                {
                    mid = (start + end) / 2;
                    if (arr[mid].CompareTo(word) == 0)
                    {
                        Console.WriteLine("word is found at this arr");
                        break;
                    }
                    else if (arr[mid].CompareTo(word) < 0)
                    {
                        start = mid + 1;
                    }
                    else if (arr[mid].CompareTo(word) > 0)
                    {
                        end = mid - 1;
                    }
                }

                if (start > end)
                {
                    Console.WriteLine("Not found");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Days of week the specified date.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="month">The month.</param>
        /// <param name="year">The year.</param>
        public static void Daysofweek(int date, int month, int year)
        {
            int y0 = (year - 14 - month) / 12;
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = month + (12 * ((14 - month) / 12)) - 2;
            int d0 = ((date + x + 31) * (m0 / 12)) % 7;
        }

        /// <summary>
        /// Determines whether this instance is prime.
        /// </summary>
        public static void IsPrime()
        {
            ////initialie variables
            int i, j, count;
            Console.WriteLine("\nPrime Numbers b/w 0 - 1000");
            for (i = 0; i < 1000; i++)
            {
                count = 0;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }

                if (count == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        /// <summary>
        /// Square the of t.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>IT RETURNS DOUBLE VALUE.</returns>
        public static double SquareOfT(int c)
        {
            double t = c;
            double epsilon = 1e-15;
            while (Math.Abs(t - (c / t)) > (epsilon * t))
            {
                t = ((c / t) + t) / 2.0;
            }

            return t;
        }

        /// <summary>
        /// conversion program.
        /// </summary>
        public static void Temprature()
        {
            Console.WriteLine("Enter tempreture in celsius");
            double celsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter tempreture in Fahrenheit");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsiustoFahrenheit = (celsius * 9 / 5) + 32;
            double fahrenheittoCelcius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine(celsiustoFahrenheit);
            Console.WriteLine(fahrenheittoCelcius);
        }

        /// <summary>
        /// Monthly payment this instance.
        /// </summary>
        public static void Monthlypayment()
        {
            Console.WriteLine("Enter Principal loan amount");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter year");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Percent");
            double r1 = Convert.ToDouble(Console.ReadLine());

            double n = 12 * y;
            double r = r1 / (12 * 100);

            double payment = ((p * r1) / 1) - Math.Pow(1 + r1, -n);
            Console.WriteLine(payment);
        }

        /// <summary>
        /// Conversion the specified number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>it returns integer type of value.</returns>
        public static int Conversion(int number)
        {
            //// int[] arr = new int[8];
            //// or (int i = 0; i < arr.Length; i++)
            //// {
            //// arr[i] = 0;
            //// }

            //// int k = 0;
            //// while (number > 0)
            //// {
            //// arr[k] = number % 2;
            //// number /= 2;
            //// k++;
            //// }
            //// for (int i = 0; i < arr.Length; i++)
            //// {
            //// int temp = arr[i];
            //// arr[i] = arr[arr.Length - i - 1];
            //// arr[arr.Length - i - 1] = temp;
            //// }
            //// for (int i = 0; i < arr.Length; i++)
            //// {
            //// Console.WriteLine(arr[i]);
            //// }

            int n = number;
            int binarynum = 0;
            int i = 1;
            while (n != 0)
            {
                int rem = n % 2;
                n = n / 2;
                binarynum = binarynum + (rem * i);
                i = i * 10;
            }

            return binarynum;
        }
    }
}
