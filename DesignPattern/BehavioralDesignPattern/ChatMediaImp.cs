// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChatMediaImp.cs" company="Bridgelabz">
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
    /// <seealso cref="DesignPatterns.BehavioralDesignPattern.IChatMediator" />
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
        /// <param name="message">The MSG.</param>
        /// <param name="user">The user.</param>
        public void SendMessage(string message, User user)
        {
            foreach (User users in this.users)
            {
                if (users != user)
                {
                    users.Receive(message);
                }
            }
        }
    }

    /// <summary>
    /// User Implementation Implements User
    /// </summary>
    /// <seealso cref="DesignPatterns.BehavioralDesignPattern.User" />
    public class UserImp : User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserImp"/> class.
        /// </summary>
        /// <param name="mediator">The med.</param>
        /// <param name="name">The name.</param>
        public UserImp(IChatMediator mediator, string name) : base(mediator, name) { }

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
