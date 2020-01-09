// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueueLinkedList.cs" company="Bridgelabz">
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
    /// This is the class for queue using LinkedList.
    /// </summary>
    public class QueueLinkedList
    {

        /// <summary>
        /// this is the class for queuenode.
        /// </summary>
        public class QueueNode
        {
            public int data;
            public QueueNode next;
        }
        QueueNode front, rear;

        /// <summary>
        /// It Enqueue the data using Linked List
        /// </summary>
        /// <param name="data"></param>
        public void Enqueue(int data)
        {
            QueueNode queueNode = new QueueNode();
            if (rear == null)
            {
                queueNode.data = data;
                queueNode.next = null;
                front = queueNode;
                rear = queueNode;
            }
            else
            {
                queueNode.data = data;
                queueNode.next = null;
                rear.next = queueNode;
                rear = queueNode;
            }
        }

        /// <summary>
        /// It dequeue the data from the Linked List.
        /// </summary>
        public void Dequeue()
        {
            if (front == null && rear == null)
                Console.WriteLine("No Data Present in Queue Linked List");
            else
            {
                Console.WriteLine("The Dequeue element is: {0}", front.data);
                front = front.next;
            }
        }

        /// <summary>
        /// Return true if the queue is empty else its return false
        /// </summary>
        /// <returns></returns>
        public Boolean IsEmpty()
        {
            if (front == null && rear == null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// It Count the number of element is present in the queue.
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            int count = 0;

            if (front == null && rear == null)
                return count;

            for (QueueNode p = front; p != null; p = p.next)
                count++;

            return count;

        }

        /// <summary>
        /// It Display the list Present in the Queue Linked List.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            if (front == null && rear == null)
                return "Empty Queue";
            for (QueueNode p = front; p != null; p = p.next)
                str.Append(p.data + " ");
            return str.ToString();
        }
    }
}