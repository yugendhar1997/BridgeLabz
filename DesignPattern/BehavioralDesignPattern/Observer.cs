// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Observer.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPattern
{
    public interface Observer
    {
        public void update();
        public void setSubject(Subject sub);
    }
    public interface Subject
    {
        public void register(Observer obj);
        public void unregister(Observer obj);
        public void notifyObservers();
        public Object getUpdate(Observer obj);
        string getUpdate();
    }
}
