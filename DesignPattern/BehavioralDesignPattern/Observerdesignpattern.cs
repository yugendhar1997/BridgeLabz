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
    /// This is the class for Mytopic which implement subject interface.
    /// </summary>
    /// <seealso cref="DesignPattern.BehavioralDesignPatterns.Subject" />
    public class MyTopic : ISubject
    {
        private List<IObserver> observers;
        private String message;
        private bool changed;
        private Object MUTEX = new Object();

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
        /// <param name="obj">The object.</param>
        public void Register(IObserver obj)
        {
            if (!observers.Contains(obj)) observers.Add(obj);
        }

        /// <summary>
        /// method to Unregister specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        public void Unregister(IObserver obj)
        {
            lock (MUTEX)
            {
                observers.Remove(obj);
            }
        }

        /// <summary>
        /// method to Notifies the observer.
        /// </summary>
        public void NotifyObservers()
        {
            List<IObserver> observersLocal = null;
            ////synchronization is used to make sure any observer registered after message is received is not notified
            lock (MUTEX)
            {
                if (!this.changed)
                    return;
                observersLocal = new List<IObserver>(this.observers);
                this.changed = false;
            }
            foreach (IObserver obj in observersLocal)
            {
                obj.Update();
            }
        }

        /// <summary>
        /// method to Get the update.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public Object GetUpdate(IObserver obj)
        {
            return this.message;
        }

        /// <summary>
        /// method to Post the message.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public void postMessage(String msg)
        {
            Console.WriteLine("Message Posted to Topic:" + msg);
            this.message = msg;
            this.changed = true;
            NotifyObservers();
        }

        /// <summary>
        /// method to Get the update.
        /// </summary>
        /// <returns></returns>
        public string GetUpdate()
        {
            return this.message;
        }

        /// <summary>
        /// This is the class for Mytopic Subsciber which implement Observer interface.
        /// </summary>
        /// <seealso cref="DesignPattern.BehavioralDesignPatterns.Observer" />
        public class MyTopicSubscriber : IObserver
        {
            private String name;
            private ISubject topic;
            /// <summary>
            /// Initializes a new instance of the <see cref="MyTopicSubscriber"/> class.
            /// </summary>
            /// <param name="nm">The nm.</param>
            public MyTopicSubscriber(String nm)
            {
                this.name = nm;
            }
            /// <summary>
            /// method to Update the instance.
            /// </summary>
            public void Update()
            {
                String msg = (String)topic.GetUpdate();
                if (msg == null)
                {
                    Console.WriteLine(name + ":: No new message");
                }
                else
                {
                    Console.WriteLine(name + ":: Consuming message::" + msg);
                }
            }

            /// <summary>
            /// method to Set the subject.
            /// </summary>
            /// <param name="sub">The sub.</param>
            public void SetSubject(ISubject sub)
            {
                this.topic = sub;
            }
        }
    }
}
