// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CashCounter.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructuresProgram.QueueList
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is the class for performing cash counter operation.
    /// </summary>
    public class CashCounter
    {

        /// <summary>
        /// Cash counter list operation are performed.
        /// </summary>
        public static void CashCounterList()
        {
            QueueList.Queue qi = new QueueList.Queue();
            int choice;
            int usercount = 0;
            String name;
            char c1;
            do
            {
                Console.WriteLine("Press 1. Enter into Line");
                Console.WriteLine("press 2. Process Deposit / withdrow");
                Console.WriteLine("press 3. to show How many people in the row remaining");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        usercount++;
                        Console.WriteLine("Add the user" + usercount + " into line");
                        Console.WriteLine("Enter the Username :");
                        name = Console.ReadLine();
                        qi.EnQueue(usercount, name);
                        break;
                    case 2:
                        qi.Dequeue();
                        break;
                    case 3:
                        qi.Show();
                        break;
                    default:
                        Console.WriteLine("Enter the Valid Cases :");
                        break;
                }

                Console.WriteLine("Size is :" + qi.GetSize());
                Console.WriteLine("Do you want to continue:....Press Y or y");
                c1 = Console.ReadLine()[0];
            }
            while (c1 == 'y' || c1 == 'Y');
        }
    }
}