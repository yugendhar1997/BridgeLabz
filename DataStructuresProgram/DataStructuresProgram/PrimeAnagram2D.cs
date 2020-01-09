// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeAnagram2D.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructuresProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this is the class for Prime Anagram in 2D array.
    /// </summary>
    public class PrimeAnagram2D
    {

        /// <summary>
        /// Prime anagram number in 2d array.
        /// </summary>
        public static void PrimeNumberAnagram2D()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Prime Number that are Anagram and not an Anagram 2D Program");
                Console.WriteLine();
                Utility utils = new Utility();
                int count = 0, tempCount = 0;
                bool flag;
                string[] primeNumber = new string[200];
                while (count <= 1000)
                {
                    flag = utils.IsPrime(count);
                    if (flag)
                    {
                        primeNumber[tempCount] = count + "";
                        tempCount++;
                    }
                    count++;
                }
                Console.WriteLine();
                int anagramCount = 0, notAnagramCount = 0;
                count = 0;
                int[] thatAreAnagram = new int[tempCount];
                int[] thatAreNotAnagram = new int[tempCount];
                string str2;
                int[][] anagramNotAnagram = new int[2][];
                do
                {
                    flag = false;
                    string str1 = primeNumber[count];
                    for (int i = count + 1; i < tempCount; i++)
                    {
                        str2 = primeNumber[i];
                        if (Utility.DetectAnagram(str1, str2))
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                    {
                        thatAreAnagram[anagramCount] = Convert.ToInt32(str1);
                        anagramCount++;
                    }
                    else
                    {
                        thatAreNotAnagram[notAnagramCount] = Convert.ToInt32(str1);
                        notAnagramCount++;
                    }
                    count++;
                } while (count != tempCount);

                anagramNotAnagram[0] = new int[anagramCount];
                anagramNotAnagram[1] = new int[notAnagramCount];

                for (int i = 0; i < anagramNotAnagram.Length; i++)
                {
                    for (int j = 0; j < anagramNotAnagram[i].Length; j++)
                    {
                        if (i == 0)
                            anagramNotAnagram[i][j] = thatAreAnagram[j];
                        else
                            anagramNotAnagram[i][j] = thatAreNotAnagram[j];
                        Console.Write(anagramNotAnagram[i][j] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }

                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }
    }
}
