// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Hashing.cs" company="Bridgelabz">
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
    /// this is the class for hashing operation.
    /// </summary>
    public class Hashing
    {
        static List<int> inputhash = new List<int>();
        static int[,] hasharray = new int[10, 10];

        /// <summary>
        /// Arrange the element using hastable.
        /// </summary>
        public static void HashTable()
        {
            StreamReader sr = new StreamReader("E:/bridgelabz/DataStructuresProgram/DataStructuresProgram/linkedlist.txt");
            string line = sr.ReadToEnd();
            string[] arr = line.Split(",");
            for (int i = 0; i < arr.Length; i++)
            {
                inputhash.Add(Convert.ToInt32(arr[i]));
            }
            HashingFunction hash = new HashingFunction();
            hasharray = hash.HashFunction(inputhash);
            Console.WriteLine("Array Element");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(hasharray[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Enter the num to search");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Element found at" + (hash.Search(num) + 1) + "index in the hashtable");
        }

    }
}
