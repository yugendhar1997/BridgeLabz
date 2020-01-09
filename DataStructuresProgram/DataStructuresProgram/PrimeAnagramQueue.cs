// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeAnagramQueue.cs" company="Bridgelabz">
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
    /// Prime Anagram Number using Queue.
    /// </summary>
    public class PrimeAnagramQueue
    {

        /// <summary>
        /// Prime Number Arrangement using queue.
        /// </summary>
        public static void PrimeNumberAnagramQueue()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Prime Number Anagram using Queue Program");
                Console.WriteLine();
                Utility utils = new Utility();
                int count = 0, tempCount = 0;
                string[] primeNumber = new string[200];
                bool flag;
                QueueList.QueueLinkedList queueLinkedList1 = new QueueList.QueueLinkedList();
                QueueList.QueueLinkedList queueLinkedList2 = new QueueList.QueueLinkedList();
                while (count <= 1000)
                {
                    flag = utils.IsPrime(count);
                    if (flag)
                    {
                        primeNumber[tempCount] = count + "";
                        tempCount++;
                    }
                    count++;
                }
                count = 0;
                do
                {
                    string str1 = primeNumber[count];
                    for (int i = count + 1; i < tempCount; i++)
                    {
                        string str2 = primeNumber[i];
                        if (Utility.DetectAnagram(str1, str2))
                        {
                            queueLinkedList1.Enqueue(Convert.ToInt32(str1));
                            queueLinkedList2.Enqueue(Convert.ToInt32(str2));
                        }
                    }
                    count++;
                } while (count != tempCount);
                int n = queueLinkedList1.Size();
                string[] tempAnag = queueLinkedList1.ToString().Split(' ');
                string[] tempRevAnag = queueLinkedList2.ToString().Split(' ');
                Console.WriteLine("The Prime Number that are Anagram using Queue: ");
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
