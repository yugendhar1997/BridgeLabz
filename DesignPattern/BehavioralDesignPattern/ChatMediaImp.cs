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

    /// <summary>
    /// this is the chat mediator implementation class.
    /// </summary>
    /// <seealso cref="DesignPattern.BehavioralDesignPatterns.ChatMediator" />
    public class ChatMediaImp : IChatMediator
    {
        /// <summary>
        /// The users
        /// </summary>
        private List<User> users;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMediaImp"/> class.
        /// </summary>
        public ChatMediaImp()
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
    /// User Implementation Class
    /// </summary>
    /// <seealso cref="DesignPatterns.BehavioralDesignPattern.User" />
    public class UserImp : User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserImp"/> class.
        /// </summary>
        /// <param name="med">The med.</param>
        /// <param name="name">The name.</param>
        public UserImp(IChatMediator med, string name) : base(med, name)
        {
        }

        /// <summary>
        /// method to Send the specified MSG.
        /// </summary>
        /// <param name="message">The MSG.</param>
        public override void Send(string message)
        {
            Console.WriteLine(this.Name + ": Sending Message=" + message);
            Mediator.SendMessage(message, this);
        }

        /// <summary>
        /// method to Receive the specified MSG.
        /// </summary>
        /// <param name="message">The MSG.</param>
        public override void Receive(string message)
        {
            Console.WriteLine(this.Name + ": Received Message:" + message);
        }
    }
}
