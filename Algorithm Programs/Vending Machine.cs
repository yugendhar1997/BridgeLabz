
// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="VendingMachine.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Yugendhar Pyata"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Algorithm_Programs
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Calculate Notes
    /// </summary>
    public class VendingMachine
    {
        /// <summary>
        /// The notes
        /// </summary>
        private static int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 }; ////Declare static Array Notes

        /// <summary>
        /// Calculates the notes.
        /// </summary>
        public void CalculateNotes()
        {
            int i = 0;
            Console.WriteLine("Enter the Amount For Change");
            int amount = int.Parse(Console.ReadLine());
            int total = 0;
            while (amount != 0)
            {
                if (amount / notes[i] != 0)
                {
                    ////calculate Distinct Notes
                    total += amount / notes[i];
                    Console.WriteLine(notes[i] + "rs notes :" + (amount / notes[i]));
                    amount = amount % notes[i];
                }

                i++;
            }

            if (amount == 0)
            {
                Console.WriteLine("total notes :" + total);
            }
        }
    }
}