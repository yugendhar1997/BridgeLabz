//-----------------------------------------------------------------------
// <copyright file="stack.cs" company="Bridgelabz" Author="Jayashree sawakare">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructuresProgram.Stack
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is the stack program.
    /// </summary>
    public class stack
    {

        /// <summary>
        /// this is Node class for stack.
        /// </summary>
        public class StackNode
        {
            public int data;
            public StackNode next;
        }
        StackNode top, bottom;

        /// <summary>
        /// It Push the data on to the stack.
        /// </summary>
        /// <param name="data"></param>
        public void Push(int data)
        {
            StackNode stackNode = new StackNode();
            if (top == null)
            {
                stackNode.data = data;
                stackNode.next = null;
                top = stackNode;
                bottom = stackNode;
            }
            else
            {
                stackNode.data = data;
                stackNode.next = null;
                bottom.next = stackNode;
                bottom = stackNode;
            }
        }

        /// <summary>
        /// It Pop the element from the stack
        /// </summary>
        public void Pop()
        {
            if (top == null)
                Console.WriteLine("No Element Present in the stack.");
            else if (bottom == top)
                bottom = top = null;
            else
            {
                for (StackNode p = top; p != null; p = p.next)
                {
                    if (p.next.next == null)
                    {
                        Console.WriteLine("The Pop Element is: {0}", p.next.data);
                        p.next = null;
                        bottom = p;
                    }
                }
            }
        }

        /// <summary>
        /// It Gives the top most element present in the stack.
        /// </summary>
        public void Peek()
        {
            if (top == null)
                Console.WriteLine("No Element Present in the stack.");
            else
                Console.WriteLine("The Peek Element is: {0}", bottom.data);
        }

        /// <summary>
        /// It return true if the stack is empty or else false.
        /// </summary>
        /// <returns></returns>
        public Boolean IsEmpty()
        {
            if (top == null && bottom == null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// It return the number of element present in stack.
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            int count = 0;
            if (top == null && bottom == null)
                return count;
            else
            {
                for (StackNode p = top; p != null; p = p.next)
                    count++;
                return count;
            }
        }

        /// <summary>
        /// It Display the list Present in the Stack Linked List.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            if (top == null && bottom == null)
                return "Empty Queue";
            for (StackNode p = top; p != null; p = p.next)
                str.Append(p.data + " ");
            return str.ToString();
        }

        /// <summary>
        /// To Display the element in the list.
        /// </summary>
        public void Display()
        {
            if (top == null)
                Console.WriteLine("No Data Present");
            else
            {
                for (StackNode p = top; p != null; p = p.next)
                    Console.WriteLine(p.data);
            }
        }
    }
}