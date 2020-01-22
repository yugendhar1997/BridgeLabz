// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Observerdesignpattern.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehavioralDesignPattern
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is the class for Mytopic which implement subject interface.
    /// </summary>
    /// <seealso cref="DesignPattern.BehavioralDesignPatterns.Subject" />
    public class MyTopic : Subject
    {
        private List<Observer> observers;
        private String message;
        private bool changed;
        private Object MUTEX = new Object();

        /// <summary>
        /// Initializes a new instance of the <see cref="MyTopic"/> class.
        /// </summary>
        public MyTopic()
        {
            this.observers = new List<Observer>();
        }
        /// <summary>
        /// method to Register the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        public void register(Observer obj)
        {
            if (!observers.Contains(obj)) observers.Add(obj);
        }
        /// <summary>
        /// method to Unregister specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        public void unregister(Observer obj)
        {
            lock (MUTEX)
            {
                observers.Remove(obj);
            }
        }
        /// <summary>
        /// method to Notifies the observer.
        /// </summary>
        public void notifyObservers()
        {
            List<Observer> observersLocal = null;
            //synchronization is used to make sure any observer registered after message is received is not notified
            lock (MUTEX)
            {
                if (!changed)
                    return;
                observersLocal = new List<Observer>(this.observers);
                this.changed = false;
            }
            foreach (Observer obj in observersLocal)
            {
                obj.update();
            }
        }
        /// <summary>
        /// method to Get the update.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public Object getUpdate(Observer obj)
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
            notifyObservers();
        }
        /// <summary>
        /// method to Get the update.
        /// </summary>
        /// <returns></returns>
        public string getUpdate()
        {
            return this.message;
        }
        /// <summary>
        /// This is the class for Mytopic Subsciber which implement Observer interface.
        /// </summary>
        /// <seealso cref="DesignPattern.BehavioralDesignPatterns.Observer" />
        public class MyTopicSubscriber : Observer
        {
            private String name;
            private Subject topic;
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
            public void update()
            {
                String msg = (String)topic.getUpdate();
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
            public void setSubject(Subject sub)
            {
                this.topic = sub;
            }
        }
    }
}
