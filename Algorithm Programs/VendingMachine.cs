// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="VendingMachine.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Yugendhar Pyata"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Algorithm_Programs
{
    using System;

    /// <summary>
    /// Calculate Notes
    /// </summary>
    public static class VendingMachine
    {
        /// <summary>
        /// The notes
        /// </summary>
        private static int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 }; ////Declare static Array Notes

        /// <summary>
        /// Calculates the notes.
        /// </summary>
        public static void CalculateNotes()
        {
            Console.WriteLine("Enter the Amount For Change");
            int amount = int.Parse(Console.ReadLine());
            Utility.FindNotes(amount, notes);
        }
    }
}
