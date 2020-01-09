// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BinarySearchTree.cs" company="Bridgelabz">
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
	/// this is the program for binary tree
	/// </summary>
	public class BinarySearchTree
	{
		/// <summary>
		/// Factorial of the nodes.
		/// </summary>
		public static void FactorialNodes()
		{
			Console.WriteLine("Enter number of nodes to get number of binary search trees possible: ");
			int nodes = Convert.ToInt32(Console.ReadLine());

			int numberOfBinarySearchTrees = Utility.Factorial(2 * nodes) / (Utility.Factorial(nodes + 1) * Utility.Factorial(nodes));
			Console.WriteLine(numberOfBinarySearchTrees + " Binary Search Trees are possible for " + nodes + " nodes");

		}
	}
}
