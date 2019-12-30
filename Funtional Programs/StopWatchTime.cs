// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StopWatchTime.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// Finds Elapsed Time
    /// </summary>
    public class StopWatchTime
    {
        /// <summary>
        /// Watches this instance.
        /// </summary>
        public void Watch()
        {
            var sw = Stopwatch.StartNew();
            Console.ReadKey();
            long ticks = sw.ElapsedTicks;
            Console.WriteLine("Elapsed Time is:" + (ticks % 1000));
        }
    }
}
