//-----------------------------------------------------------------------
// <copyright file="StackOperation.cs" company="Bridgelabz" Author="Jayashree sawakare">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructuresProgram.Stack
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this is the class for stack operation.
    /// </summary>
    public class StackOperation
    {
        char[] stack = new char[10];
        int top = -1;

        /// <summary>
        /// Push the specified character.
        /// </summary>
        /// <param name="c">The c.</param>
        public void Push(char c)
        {
            top++;
            stack[top] = c;
        }
        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            if (top == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Peek the instance.
        /// </summary>
        /// <returns></returns>
        public char Peek()
        {
            char c = stack[top];
            return c;
        }

        /// <summary>
        /// Pop this instance.
        /// </summary>
        public void Pop()
        {
            char data = stack[top];
            stack[top] = ' ';
            top--;
        }
    }
}
