// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChatMediator.cs" company="Bridgelabz">
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
    /// This is an interface of chatMediator.
    /// </summary>
    public interface ChatMediator
    {
        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        /// <param name="user">The user.</param>
        public void SendMessage(string msg, User user);
        /// <summary>
        /// Adds the user.
        /// </summary>
        /// <param name="user">The user.</param>
        void AddUser(User user);
    }

    /// <summary>
    /// This is an abstract class for User.
    /// </summary>
    public abstract class User
    {
        protected ChatMediator mediator;
        protected string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="med">The med.</param>
        /// <param name="name">The name.</param>
        public User(ChatMediator med, string name)
        {
            this.mediator = med;
            this.name = name;
        }

        /// <summary>
        /// Sends the specified MSG.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public abstract void Send(string msg);

        /// <summary>
        /// Receives the specified MSG.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public abstract void Receive(string msg);

    }
}
