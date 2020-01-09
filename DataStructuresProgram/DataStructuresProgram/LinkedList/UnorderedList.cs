// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnorderedList.cs" company="Bridgelabz">
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
    /// this is the class for Unordered Linked List.
    /// </summary>
    public class UnorderedList
    {
        /// <summary>
        /// Linkedlis Operation are performed.
        /// </summary>
        public static void linkedlist()
        {
            LinkedList lst = new LinkedList();
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
            char c1;
            do
            {
                Console.WriteLine(" 1. create Linked List");
                Console.WriteLine(" 2. Insert At Begning");
                Console.WriteLine(" 3. Insert At End");
                Console.WriteLine(" 4. Insert At Given Position");
                Console.WriteLine(" 5. Seach Element");
                Console.WriteLine(" 6. Delete An Element form begning ");
                Console.WriteLine(" 7. Delete At End ");
                Console.WriteLine(" 8. Delete At Given Positon ");
                Console.WriteLine(" 9. Find the Length of Linked List ");
                Console.WriteLine(" 10. isEmpty");
                Console.WriteLine(" 11. Display the List ");
                Console.WriteLine("Enter choica");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        string firstLine;
                        while ((firstLine = sr.ReadLine()) != null)
                        {
                            string[] stringArray = firstLine.Split(' ');
                            foreach (string itemFirst in stringArray)
                            {
                                int number = 0;
                                int.TryParse(itemFirst, out number);
                                lst.AddLast(number);
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the data");
                        int data = Convert.ToInt32(Console.ReadLine());
                        lst.AddFirst(data);
                        break;
                    case 3:
                        Console.WriteLine("Enter the data");
                        data = Convert.ToInt32(Console.ReadLine());
                        lst.AddLast(data);
                        break;
                    case 4:
                        Console.WriteLine("Enter the position");
                        int position = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the data");
                        data = Convert.ToInt32(Console.ReadLine());
                        lst.InsertAt(position, data);
                        break;
                    case 5:
                        Console.WriteLine("Enter the data");
                        data = Convert.ToInt32(Console.ReadLine());
                        if (lst.SearchItem(data))
                        {
                            int a = lst.Index(data);
                            Console.WriteLine("data is at position" + a);
                        }
                        break;
                    case 6:
                        lst.DeleteFirst();
                        break;
                    case 7:
                        lst.DeleteLast();
                        break;
                    case 8:
                        Console.WriteLine("Enter the postion");
                        int index = Convert.ToInt32(Console.ReadLine());
                        lst.DeleteAt(index);
                        break;
                    case 9:
                        lst.Length();
                        break;
                    case 10:
                        Console.WriteLine(lst.IsEmpty());
                        break;
                    case 11:
                        Console.WriteLine("The length of the list is    -----> " + lst.Length());
                        Console.WriteLine(" empty list is    -----> " + lst.IsEmpty());
                        lst.show();
                        break;
                    default:
                        Console.WriteLine("Enter wrong option");
                        break;
                }

                Console.WriteLine("Do you want to continue:....Press Y or y");
                c1 = Console.ReadLine()[0];
            }
            while (c1 == 'y' || c1 == 'Y');
        }

    }
}

