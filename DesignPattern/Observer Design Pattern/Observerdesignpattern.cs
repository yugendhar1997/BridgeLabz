// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Observerdesignpattern.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehavioralDesignPattern
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// My Topic Implements Subject Interface
    /// </summary>
    /// <seealso cref="DesignPatterns.BehavioralDesignPattern.ISubject" />
    public class MyTopic : ISubject
    {
        /// <summary>
        /// The observers
        /// </summary>
        private List<IObserver> observers;

        /// <summary>
        /// The message
        /// </summary>
        private string message;

        /// <summary>
        /// The changed
        /// </summary>
        private bool changed;

        /// <summary>
        /// The mutex
        /// </summary>
        private object mutex = new object();

        /// <summary>
        /// Initializes a new instance of the <see cref="MyTopic"/> class.
        /// </summary>
        public MyTopic()
        {
            this.observers = new List<IObserver>();
        }

        /// <summary>
        /// method to Register the specified object.
        /// </summary>
        /// <param name="objects">The object.</param>
        public void Register(IObserver objects)
        {
            if (!observers.Contains(objects)) this.observers.Add(objects);
        }

        /// <summary>
        /// method to Unregister specified object.
        /// </summary>
        /// <param name="objects">The object.</param>
        public void Unregister(IObserver objects)
        {
            lock (this.mutex)
            {
                this.observers.Remove(objects);
            }
        }

        /// <summary>
        /// method to Notifies the observer.
        /// </summary>
        public void NotifyObservers()
        {
            List<IObserver> observersLocal = null;
            ////synchronization is used to make sure any observer registered after message is received is not notified
            lock (this.mutex)
            {
                if (!this.changed)
                {
                    return;
                }

                observersLocal = new List<IObserver>(this.observers);
                this.changed = false;
            }

            foreach (IObserver objects in observersLocal)
            {
                objects.Update();
            }
        }

        /// <summary>
        /// method to Get the update.
        /// </summary>
        /// <param name="objects">The object.</param>
        /// <returns>The Message</returns>
        public object GetUpdate(IObserver objects)
        {
            return this.message;
        }

        /// <summary>
        /// method to Post the message.
        /// </summary>
        /// <param name="message">The MSG.</param>
        public void PostMessage(string message)
        {
            Console.WriteLine("Message Posted to Topic:" + message);
            this.message = message;
            this.changed = true;
            this.NotifyObservers();
        }

        /// <summary>
        /// method to Get the update.
        /// </summary>
        /// <returns>The Message</returns>
        public string GetUpdate()
        {
            return this.message;
        }

        /// <summary>
        /// My Topic Subscriber Which Implements Observer Interface
        /// </summary>
        /// <seealso cref="DesignPatterns.BehavioralDesignPattern.IObserver" />
        public class MyTopicSubscriber : IObserver
        {
            /// <summary>
            /// The name
            /// </summary>
            private string name;

            /// <summary>
            /// The topic
            /// </summary>
            private ISubject topic;

            /// <summary>
            /// Initializes a new instance of the <see cref="MyTopicSubscriber"/> class.
            /// </summary>
            /// <param name="name">The nm.</param>
            public MyTopicSubscriber(string name)
            {
                this.name = name;
            }

            /// <summary>
            /// method to Update the instance.
            /// </summary>
            public void Update()
            {
                string message = (string)this.topic.GetUpdate();
                if (message == null)
                {
                    Console.WriteLine(this.name + ":: No new message");
                }
                else
                {
                    Console.WriteLine(this.name + ":: Consuming message::" + message);
                }
            }

            /// <summary>
            /// method to Set the subject.
            /// </summary>
            /// <param name="subject">The sub.</param>
            public void SetSubject(ISubject subject)
            {
                this.topic = subject;
            }
        }
    }
}
