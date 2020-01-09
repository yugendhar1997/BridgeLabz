// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeAnagramStack.cs" company="Bridgelabz">
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
    /// this is the program for prime anagram using stack.
    /// </summary>
    public class PrimeAnagramStack
    {

        /// <summary>
        /// Prime anagram number print using stack.
        /// </summary>
        public static void PrimeNumberAnagramStack()
        {
            try
            {
                Utility utils = new Utility();
                Stack.stack stackLinkedList1 = new Stack.stack();
                Stack.stack stackLinkedList2 = new Stack.stack();
                int count = 0, tempCount = 0;
                string[] primeNumber = new string[200];
                while (count <= 1000)
                {
                    bool flag = utils.IsPrime(count);
                    if (flag)
                    {
                        primeNumber[tempCount] = count + "";
                        tempCount++;
                    }
                    count++;
                }
                Console.WriteLine();
                count = 0;
                do
                {
                    string str1 = primeNumber[count];
                    for (int i = count + 1; i < tempCount; i++)
                    {
                        string str2 = primeNumber[i];
                        if (Utility.DetectAnagram(str1, str2))
                        {
                            stackLinkedList1.Push(Convert.ToInt32(str1));
                            stackLinkedList2.Push(Convert.ToInt32(str2));
                        }
                    }
                    count++;
                } while (count != tempCount);
                int n = stackLinkedList1.Size();
                string[] tempAnag = stackLinkedList1.ToString().Split(' ');
                string[] tempRevAnag = stackLinkedList2.ToString().Split(' ');
                Array.Reverse(tempAnag);
                Array.Reverse(tempRevAnag);
                Console.WriteLine("The Prime Number that are Anagram using Stack: ");
                for (int i = 0; i < n; i++)
                    Console.WriteLine(tempAnag[i] + " " + tempRevAnag[i]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }
    }
}
