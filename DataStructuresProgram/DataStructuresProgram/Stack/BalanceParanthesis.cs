//-----------------------------------------------------------------------
// <copyright file="BalanceParanthesis.cs" company="Bridgelabz" Author="Jayashree sawakare">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructuresProgram.Stack
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is the program for balance paranthesis.
    /// </summary>
    public class BalanceParanthesis
    {
        /// <summary>
        /// Paranthesis check function.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
        public static bool ParaCheckFun(String str)
        {
            char[] exp = new char[100];
            exp = str.ToCharArray();
            StackOperation st = new StackOperation();
            int flag = 0;
            if (exp[0] == '}' || exp[0] == ']' || exp[0] == ')')
            {
                return false;
            }
            else
            {
                foreach (char c in exp)
                {
                    if (c == '{' || c == '[' || c == '(')
                    {
                        st.Push(c);
                    }
                    else if (c == '}' || c == ']' || c == ')')
                    {
                        bool pair = PairCheck(st.Peek(), c);
                        if (st.IsEmpty())
                        {
                            flag = 1;
                            break;
                        }
                        else if (pair)
                        {
                            st.Pop();
                        }
                        else
                        {
                            st.Push(c);
                        }
                    }
                }
                if (flag == 0 && st.IsEmpty())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Pairs check Function.
        /// </summary>
        /// <param name="open">The open.</param>
        /// <param name="close">The close.</param>
        /// <returns></returns>
        public static bool PairCheck(char open, char close)
        {
            if (open == '{' && close == '}')
            {
                return true;
            }
            else if (open == '[' && close == ']')
            {
                return true;
            }
            else if (open == '(' && close == ')')
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }
}