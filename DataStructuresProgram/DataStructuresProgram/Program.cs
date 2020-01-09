// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructuresProgram
{
    using System;
    using System.IO;

    /// <summary>
    /// This is the main class of execution.
    /// </summary>
    public class Program
    {

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("\n 1  : Unordered Linkedlist\n 2  : Ordered Linked list \n 3  : Balanced Paranthesis \n 4  : Cash Counter \n 5  : Prime checker 2D Array \n 6  : Palindrome checker \n 7  : calender \n 8  : Prime Anagram Checker  \n 9  : Prime Anagram Queue \n 10 : Prime Anagram Stack \n 11 : Hashing Function \n 12 : Binary Search Trees \n 13 : Exite\n");
                    Console.WriteLine("Enter your choice");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            LinkedList.UnorderedList.linkedlist();
                            break;
                        case 2:
                            LinkedList.OrderListOperation.Orderlist();
                            break;
                        case 3:
                            Console.WriteLine("Enter Expression");
                            string str = Console.ReadLine();
                            bool result;
                            result = Stack.BalanceParanthesis.ParaCheckFun(str);

                            if (result)
                            {
                                Console.WriteLine("This is Balance parantheses");
                            }
                            else
                            {
                                Console.WriteLine("This is NOt Balance parantheses");
                            }

                            break;
                        case 4:
                            QueueList.CashCounter.CashCounterList();
                            break;
                        case 5:
                            PrimeNum2DArray.primeArray();
                            break;
                        case 6:
                            PalindromeChecker.Palindrome();
                            break;
                        case 7:
                            Calender.CalenderOfMonth();
                            break;
                        case 8:
                            PrimeAnagram2D.PrimeNumberAnagram2D();
                            break;
                        case 9:
                            PrimeAnagramQueue.PrimeNumberAnagramQueue();
                            break;
                        case 10:
                            PrimeAnagramStack.PrimeNumberAnagramStack();
                            break;
                        case 11:
                            Hashing.HashTable();
                            break;
                        case 12:
                            BinarySearchTree.FactorialNodes();
                            break;
                        case 13:
                            flag = false;
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}


