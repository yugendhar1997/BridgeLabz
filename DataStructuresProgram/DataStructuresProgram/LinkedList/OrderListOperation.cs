// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OrderListOperation.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructuresProgram.LinkedList
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    /// <summary>
    /// This is the Operation for order linked list.
    /// </summary>
    public class OrderListOperation
    {

        /// <summary>
        /// Orderlist of the element.
        /// </summary>
        public static void Orderlist()
        {
            OrderedList lst = new OrderedList();
            StreamWriter sw = new StreamWriter("D:/bridgelabz/DataStructuresProgram/DataStructuresProgram/linkedlist.txt");
            Console.WriteLine("Enter no of lines");
            int no = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < no; i++)
            {
                string lines = Console.ReadLine();
                sw.WriteLine(lines);
            }
            sw.Close();
            StreamReader sr = new StreamReader("D:/bridgelabz/DataStructuresProgram/DataStructuresProgram/linkedlist.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] strArr = line.Split(" ");
                int number = 0;
                foreach (string itemElement in strArr)
                {
                    int.TryParse(itemElement, out number);
                    lst.sortedInsert(number);
                    lst.show();
                }
            }
            Console.WriteLine("Enter item to be search");
            int item = Convert.ToInt32(Console.ReadLine());
            if (lst.SearchItem(item))
            {
                int index = lst.Index(item);
                Console.WriteLine("item is found at " + index);
                lst.DeleteAt(index);
                lst.show();
            }
            else
            {
                lst.Add(item);
                lst.show();
            }
        }
    }
}