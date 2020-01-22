// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChatMediatorImp.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehavioralDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this is the chat mediator implementation class.
    /// </summary>
    /// <seealso cref="DesignPattern.BehavioralDesignPatterns.ChatMediator" />
    public class ChatMediatorImp : ChatMediator
    {
        private List<User> users;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMediatorImpl"/> class.
        /// </summary>
        public ChatMediatorImp()
        {
            this.users = new List<User>();
        }

        /// <summary>
        /// method to Add the user.
        /// </summary>
        /// <param name="user">The user.</param>
        public void AddUser(User user)
        {
            this.users.Add(user);
        }

        /// <summary>
        /// method for Send the message.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        /// <param name="user">The user.</param>
        public void SendMessage(string msg, User user)
        {
            foreach (User u in this.users)
            {
                if (u != user)
                {
                    u.Receive(msg);
                }
            }
        }
    }

    /// <summary>
    /// This is an User Implementation class.
    /// </summary>
    /// <seealso cref="DesignPattern.BehavioralDesignPatterns.User" />
    public class UserImpl : User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserImpl"/> class.
        /// </summary>
        /// <param name="med">The med.</param>
        /// <param name="name">The name.</param>
        public UserImpl(ChatMediator med, string name) : base(med, name)
        {
        }

        /// <summary>
        /// method to Send the specified MSG.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public override void Send(string msg)
        {
            Console.WriteLine(this.name + ": Sending Message=" + msg);
            mediator.SendMessage(msg, this);
        }

        /// <summary>
        /// method to Receive the specified MSG.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public override void Receive(string msg)
        {
            Console.WriteLine(this.name + ": Received Message:" + msg);
        }
    }
}
