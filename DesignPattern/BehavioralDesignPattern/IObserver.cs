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
        /// <param name="sub">The sub.</param>
        public void SetSubject(ISubject sub);
    }

    /// <summary>
    /// Subject Interface
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// Registers the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        public void Register(IObserver obj);

        /// <summary>
        /// Unregisters the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        public void Unregister(IObserver obj);

        /// <summary>
        /// Notifies the observers.
        /// </summary>
        public void NotifyObservers();

        /// <summary>
        /// Gets the update.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns>obj</returns>
       public Object GetUpdate(IObserver obj);

        /// <summary>
        /// Gets the update.
        /// </summary>
        /// <returns></returns>
        string GetUpdate();
    }
}
