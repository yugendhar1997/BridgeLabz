// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PalindromeChecker.cs" company="Bridgelabz">
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
    /// this is the program for palindrome checker.
    /// </summary>
    public class PalindromeChecker
    {

        /// <summary>
        /// Palindrome checker for string.
        /// </summary>
        public static void Palindrome()
        {
            try
            {
                Console.Write("Enter the String: ");
                string str = Console.ReadLine();
                Utility utils = new Utility();
                if (utils.CheckPalindrome(str))
                    Console.WriteLine("The String is a Palindrome");
                else
                    Console.WriteLine("The String is not a Palindrome");
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }
    }
}
