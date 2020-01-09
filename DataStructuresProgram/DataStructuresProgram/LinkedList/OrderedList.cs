// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OrderedList.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructuresProgram.LinkedList
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this is class for ordered Linked list.
    /// </summary>
    public class OrderedList
    {
        public Node head;
        int length = 0;
        /// <summary>
        /// Node class for ordered Linked List.
        /// </summary>
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        /// <summary>
        /// Sorted element insert.
        /// </summary>
        /// <param name="data">The data.</param>
        public void sortedInsert(int data)
        {
            Node new_node = new Node(data);
            Node current;
            if (head == null || head.data >= new_node.data)
            {
                new_node.next = head;
                head = new_node;
            }
            else
            {
                current = head;

                while (current.next != null &&
                    current.next.data < new_node.data)
                    current = current.next;

                new_node.next = current.next;
                current.next = new_node;
            }
        }

        /// <summary>
        /// Add the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Add(int data)
        {
            Node node = new Node(data);
            node.data = data;
            node.next = null;
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    n = n.next;
                }
                n.next = node;
            }
        }

        /// <summary>
        /// Delete the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Delete(int data)
        {
            Node node = new Node(data);
            node.data = data;
            node.next = null;
            if (head != null)
            {
                Node last = head;
                Node previous = null;
                while (last.next != null)
                {
                    previous = last;
                    last = last.next;
                }
                previous.next = null;
            }
        }

        /// <summary>
        /// Search the item.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
        public bool SearchItem(Object str)
        {
            Node current = head;
            while (current != null)
            {
                if (current.data.Equals(str))
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }

        /// <summary>
        /// Index the specified search item.
        /// </summary>
        /// <param name="SearchItem">The search item.</param>
        /// <returns></returns>
        public int Index(int SearchItem)
        {
            Node current = head;
            int index = 1;
            while (current != null)
            {
                if (current.data.Equals(SearchItem))
                {
                    return index;
                }
                current = current.next;
                index++;
            }
            return -1;
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Delete at specified position.
        /// </summary>
        /// <param name="position">The position.</param>
        public void DeleteAt(int position)
        {
            Node previous = head;
            Node previousTolast = null;
            int count = 0;
            if (position == 1)
            {
                Node temp = head;
                head = head.next;
                temp.next = null;
            }
            else
            {
                while (count < position - 1)
                {
                    previousTolast = previous;
                    previous = previous.next;
                    count++;
                }
                Node temp = previous.next;
                previousTolast.next = temp;
                length--;
            }
        }

        /// <summary>
        /// Show the list of element.
        /// </summary>
        public void show()
        {
            Node node = head;
            while (node != null)
            {
                Console.Write(node.data + "->");
                node = node.next;
            }
            Console.WriteLine();
        }

    }
}