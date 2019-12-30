// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReplaceString.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------    
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// Replaces Usernames given by user
    /// </summary>
    public class ReplaceString
    {
        /// <summary>
        /// Replaces the strings.
        /// </summary>
        public void ReplaceStrings()
        {
            Console.WriteLine("Enter The Source Term of String");
            string source = Console.ReadLine();

            Console.WriteLine("Enter The Search Term of String");
            string search = Console.ReadLine();

            Console.WriteLine("Enter The Replace Term of String");
            string replace = Console.ReadLine();

            string output = source.Replace(search, replace);

            Console.WriteLine();
            Console.WriteLine("Befor Replacing The String : " + source);
            Console.WriteLine("After Reaplacing The String : " + output);
        }
    }
}
