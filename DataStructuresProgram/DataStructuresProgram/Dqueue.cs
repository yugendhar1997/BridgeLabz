// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Dqueue.cs" company="Bridgelabz">
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
    /// this is dequeue class for Dqueue operation.
    /// </summary>
    public class Dqueue
    {
        char[] deque = new char[1000];
        int front = -1, rear = -1;

        /// <summary>
        /// It add the Element at the front of deque.
        /// </summary>
        /// <param name="character"></param>
        public void AddFront(char character)
        {
            if (front == -1)
            {
                front++;
                deque[front] = character;
                rear++;
            }
            else
            {
                rear++;
                for (int i = rear; i >= 1; i--)
                {
                    deque[i] = deque[i - 1];
                }
                deque[front] = character;
            }
        }

        /// <summary>
        /// It Add the element at the rear of the deque.
        /// </summary>
        /// <param name="character"></param>
        public void AddRear(char character)
        {
            if (rear == -1)
            {
                rear++;
                deque[rear] = character;
                front++;
            }
            else
            {
                rear++;
                deque[rear] = character;
            }
        }

        /// <summary>
        /// It removes the element from the front of deque.
        /// </summary>
        public char RemoveFront()
        {
            if (front == -1)
                return '0';
            else
            {
                char a = deque[front];
                for (int i = 0; i < rear; i++)
                    deque[i] = deque[i + 1];
                rear--;
                return a;
            }
        }

        /// <summary>
        /// It Removes the element from the rear of deque.
        /// </summary>
        public char RemoveRear()
        {
            if (rear == -1)
                return '0';
            else
            {
                char a = deque[rear];
                deque[rear] = ' ';
                rear--;
                return a;
            }
        }

        /// <summary>
        /// It returns true if the deque is empty or else false
        /// </summary>
        /// <returns></returns>
        public Boolean IsEmpty()
        {
            if (front == -1 && rear == -1 || front == rear)
                return true;
            else
                return false;
        }

        /// <summary>
        /// It return the number of element in deque
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            if (front == -1 && rear == -1)
                return 0;
            else
                return rear - front;
        }
    }
}