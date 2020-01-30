// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IObserver.cs" company="Bridgelabz">
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
    /// Observer Interface
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Updates this instance.
        /// </summary>
        public void Update();

        /// <summary>
        /// Sets the subject.
        /// </summary>
        /// <param name="subject">The sub.</param>
        public void SetSubject(ISubject subject);
    }

    /// <summary>
    /// Subject Interface
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// Registers the specified object.
        /// </summary>
        /// <param name="objects">The object.</param>
        public void Register(IObserver objects);

        /// <summary>
        /// Unregisters the specified object.
        /// </summary>
        /// <param name="objects">The object.</param>
        public void Unregister(IObserver objects);

        /// <summary>
        /// Notifies the observers.
        /// </summary>
        public void NotifyObservers();

        /// <summary>
        /// Gets the update.
        /// </summary>
        /// <param name="objects">The object.</param>
        /// <returns>The object</returns>
        public object GetUpdate(IObserver objects);

        /// <summary>
        /// Gets the update.
        /// </summary>
        /// <returns>The Status</returns>
        string GetUpdate();
    }
}
