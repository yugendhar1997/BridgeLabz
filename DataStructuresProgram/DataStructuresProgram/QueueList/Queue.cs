// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Queue.cs" company="Bridgelabz">
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
    /// this is class for performing queue operations.
    /// </summary>
    public class Queue
    {
        public Node front;
        public Node rear;
        public int size;
        public int data;
        static int bankamount = 500;
        int[] queue = new int[10];

        /// <summary>
        /// Initializes a new instance of the <see cref="Queue"/> class.
        /// </summary>
        public Queue()
        {
            front = null;
            rear = null;
            size = 0;
        }

        /// <summary>
        /// Node class for queue.
        /// </summary>
        public class Node
        {
            int no;
            private String name;
            private Node next;
            public Node()
            {
                no = 0;
                name = null;
                next = null;
            }
            Node(String name, Node next, int no)
            {
                this.no = no;
                this.name = name;
                this.next = next;
            }

            /// <summary>
            /// Get the number.
            /// </summary>
            /// <returns></returns>
            public int GetNo()
            {
                return no;
            }

            /// <summary>
            /// Set the number.
            /// </summary>
            /// <param name="no">The no.</param>
            public void SetNo(int no)
            {
                this.no = no;
            }

            /// <summary>
            /// Get the name.
            /// </summary>
            /// <returns></returns>
            public String GetName()
            {
                return name;
            }

            /// <summary>
            /// Set the name.
            /// </summary>
            /// <param name="name">The name.</param>
            public void SetName(String name)
            {
                this.name = name;
            }

            /// <summary>
            /// Get the next.
            /// </summary>
            /// <returns></returns>
            public Node GetNext()
            {
                return next;
            }

            /// <summary>
            /// Set the next.
            /// </summary>
            /// <param name="next">The next.</param>
            public void SetNext(Node next)
            {
                this.next = next;
            }
        }

        /// <summary>
        /// Deposite cash method
        /// </summary>
        /// <returns></returns>
        public int Deposite()
        {
            int amount;
            Console.WriteLine("Enter the Ammount :");
            amount = Convert.ToInt32(Console.ReadLine());
            if (amount > 500)
            {
                bankamount = bankamount + amount;
            }
            else
            {
                Console.WriteLine("Please Enter the Amount >= 500");
                Deposite();
            }
            return bankamount;
        }

        /// <summary>
        /// Get the size.
        /// </summary>
        /// <returns></returns>
        public int GetSize()
        {
            return size;
        }

        /// <summary>
        /// Widtdraw the cash method.
        /// </summary>
        /// <returns></returns>
        public int Widtdraw()
        {
            int amount;
            Console.WriteLine("Enter the Ammount :");
            amount = Convert.ToInt32(Console.ReadLine());
            if (amount < bankamount)
            {
                bankamount = bankamount - amount;
            }
            else
            {
                Console.WriteLine("Please enter the amount < " + bankamount);
                Widtdraw();
            }
            return amount;
        }

        /// <summary>
        /// Enqueue operation for adding element.
        /// </summary>
        /// <param name="no">The no.</param>
        /// <param name="name">The name.</param>
        public void EnQueue(int no, String name)
        {
            Node n = new Node();
            n.SetNo(no);
            n.SetName(name);
            n.SetNext(rear);
            if (front == null)
            {
                front = n;
                rear = n;
                n.SetNext(rear);
            }
            else
            {
                rear.SetNext(n);
                rear = n;
                rear.SetNext(null);
            }
            size++;
            Console.WriteLine("user " + rear.GetNo() + " :" + rear.GetName() + " has added.......please next!!!! ");
        }

        /// <summary>
        /// Dequeue operation for removing element.
        /// </summary>
        public void Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Node t;
                t = front;
                Console.WriteLine("Enter the user " + t.GetNo() + " choice :");
                Console.WriteLine("1. Deposit :");
                Console.WriteLine("2. Widthrow : ");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Deposite();
                        front = front.GetNext();
                        Console.WriteLine("please next!!!! ");
                        size--;
                        Console.WriteLine("Amount is : " + bankamount);
                        break;
                    case 2:
                        if (Widtdraw() < 0)
                        {
                            front = front.GetNext();
                            size--;
                            Console.WriteLine("Amount is : " + bankamount);
                            Console.WriteLine("please next!!!! ");
                        }
                        else
                        {
                            Console.WriteLine("Not Have enough cash..Please Deposit First....!!!!!!:");
                        }
                        break;
                    default:
                        Console.WriteLine("Enter valid  choice :");
                        break;
                }
            }
        }

        /// <summary>
        /// Show the element in the queue.
        /// </summary>
        public void Show()
        {
            Node t;
            t = front;
            if (front == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine("Next User is : " + front.GetName());
                Console.WriteLine("User List .................");
                while (t != rear)
                {
                    Console.WriteLine(" User " + t.GetNo() + " : " + t.GetName());
                    t = t.GetNext();
                }
                Console.WriteLine(" User " + t.GetNo() + " : " + t.GetName());
            }
        }
    }
}
