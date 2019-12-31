// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SqrtNewtonMethod.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Algorithm_Programs
{
    using System;

    /// <summary>
    /// Finds The Roots Of A Quadratic Equation
    /// </summary>
    public class SqrtNewtonMethod
    {
        /// <summary>
        /// Newton the method.
        /// </summary>
        public static void NewtonsMethod()
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            double result = Utility.SquareOfT(num);
            Console.WriteLine(result);
        }
    }
}
