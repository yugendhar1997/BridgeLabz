// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedList.cs" company="Bridgelabz">
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
    /// this is an LinkedList class.
    /// </summary>
    public class LinkedList
    {
        public Node head;
        public Node top;

        /// <summary>
        /// Add the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void AddLast(int data)
        {
            try
            {
                Node node = new Node();
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        /// <summary>
        /// Add the element at first.
        /// </summary>
        /// <param name="data">The data.</param>
        public void AddFirst(int data)
        {
            try
            {
                Node node = new Node();
                node.data = data;
                if (head == null)
                {
                    node.next = head;
                    head = node;
                }
                else
                {
                    node.next = head;
                    head = node;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Insert data at index position.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="data">The data.</param>
        public void InsertAt(int index, int data)
        {
            try
            {
                Node node = new Node();
                node.data = data;
                node.next = null;
                if (index == 1)
                {
                    node.next = head;
                    head = node;
                }
                Node n = head;
                for (int i = 1; i <= (index - 2); i++)
                {
                    n = n.next;
                }
                node.next = n.next;
                n.next = node;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Delete the first element.
        /// </summary>
        /// <returns></returns>
        public bool DeleteFirst()
        {
            try
            {
                Node temp = head;
                head = head.next;
                temp.next = null;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// <summary>
        /// Delete the last element.
        /// </summary>
        /// <returns></returns>
        public bool DeleteLast()
        {
            try
            {
                Node n = head;
                Node previous = null;
                while (n.next != null)
                {
                    previous = n;
                    n = n.next;
                }
                previous.next = null;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// <summary>
        /// Delete at specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        public void DeleteAt(int index)
        {
            try
            {
                Node node = new Node();
                Node temp1 = head;
                if (index == 1)
                {
                    head = temp1.next;
                    temp1 = null;
                    return;
                }
                else
                {
                    for (int i = 1; i < index; i++)
                    {
                        temp1 = temp1.next;
                        Node temp2 = temp1.next;
                        temp1.next = temp2.next;
                        temp2 = null;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Delete the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Delete(int data)
        {
            Node node = new Node();
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
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public bool SearchItem(int item)
        {
            Node current = head;
            while (current != null)
            {
                if (current.data.Equals(item))
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
        /// Determine whether this instance is empty.
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
        /// Pop/delete the element.
        /// </summary>
        /// <returns></returns>
        public int pop()
        {
            Node node = head;
            Node previous = head;
            if (node == null)
            {
                Console.WriteLine("Underflow");
            }
            else if (node.next == null)
            {
                head = null;
            }
            else
            {
                while (node.next != null)
                {
                    previous = node;
                    node = node.next;
                }
                previous.next = null;
            }
            return -1;
        }

        /// <summary>
        /// Peek the element.
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            Node node = head;
            Node previous = head;
            while (node.next != null)
            {
                node = node.next;
            }
            return node.data;
        }

        /// <summary>
        /// Append the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Append(int data)
        {
            Node node = new Node();
            node.data = data;
            Node tempnode = head;
            while (tempnode.next != null)
            {
                tempnode = tempnode.next;
            }
            tempnode.next = node;
        }

        /// <summary>
        /// total length/size of element.
        /// </summary>
        /// <returns></returns>
        public int Length()
        {
            Node node = head;
            int size = 0;
            {
                while (node != null)
                {
                    size++;
                    node = node.next;
                }
            }
            return size;
        }

        /// <summary>
        /// Pop element at the specified position.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <returns></returns>
        public int Pop(int position)
        {
            Node node = head;
            Node previous = head;
            Node checkpos = head;
            int pos = 0;
            int count = 1;
            bool isvalid = false;
            while (checkpos != null)
            {
                if (pos == position)
                {
                    isvalid = true;
                    break;
                }
                pos++;
                checkpos = checkpos.next;
            }
            if (isvalid)
            {
                while (node != null)
                {
                    if (count == position)
                    {
                        break;
                    }
                    count++;
                    previous = node;
                    node = node.next;
                }
                previous.next = node.next;
                node.next = null;
                return node.data;
            }
            else
            {
                Console.WriteLine("Enter valid position");
                Console.WriteLine("Enter position");
                position = Convert.ToInt32(Console.ReadLine());
                return Pop(position);
            }

        }

        /// <summary>
        /// Shows all the element list.
        /// </summary>
        public void show()
        {
            try
            {
                Node node = head;
                while (node != null)
                {
                    Console.WriteLine(node.data);
                    node = node.next;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}