// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Anagram.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Algorithm_Programs
{
    using System;

    /// <summary>
    /// To Check Whether The Strings are Anagram or Not
    /// </summary>
    public class Anagram
    {
        /// <summary>
        /// Detects the anagram.
        /// </summary>
        public static void DetectAnagram()
        {
            Console.WriteLine("Enter 1st Word");
            string string1 = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter 2nd Word");
            string string2 = Console.ReadLine().ToUpper();
           
            Utility.PerformAnagram(string1, string2);
        }
    }
}
