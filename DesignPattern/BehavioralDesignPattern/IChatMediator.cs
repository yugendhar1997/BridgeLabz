// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IChatMediator.cs" company="Bridgelabz">
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
    public interface IChatMediator
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
        /// <summary>
        /// The mediator
        /// </summary>
        public IChatMediator Mediator;

        /// <summary>
        /// The name
        /// </summary>
        public string Name;

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="mediator">The med.</param>
        /// <param name="name">The name.</param>
        public User(IChatMediator mediator, string name)
        {
            this.Mediator = mediator;
            this.Name = name;
        }

        /// <summary>
        /// Sends the specified MSG.
        /// </summary>
        /// <param name="message">The MSG.</param>
        public abstract void Send(string message);

        /// <summary>
        /// Receives the specified MSG.
        /// </summary>
        /// <param name="message">The MSG.</param>
        public abstract void Receive(string message);
    }
}
