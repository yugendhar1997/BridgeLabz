// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehavioralDesignPattern
{
    using System;
    using System.Collections.Generic;
    using DesignPatterns.StructuralDesignPattern;
    using static DesignPatterns.BehavioralDesignPattern.MyTopic;

    /// <summary>
    /// this is the utility class.
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// method for Chat mediator program.
        /// </summary>
        public static void ChatMediatorProgram()
        {
            IChatMediator mediator = new ChatMediatorImp();
            User user1 = new UserImp(mediator, "Pankaj");
            User user2 = new UserImp(mediator, "Lisa");
            User user3 = new UserImp(mediator, "Saurabh");
            User user4 = new UserImp(mediator, "David");
            mediator.AddUser(user1);
            mediator.AddUser(user2);
            mediator.AddUser(user3);
            mediator.AddUser(user4);
            user1.Send("Hi All");
        }

        /// <summary>
        /// method for Vendor adapter program.
        /// </summary>
        public static void VendorAdapterProgram()
        {
            VenderAdapter venderAdapter = new VenderAdapter();
            List<string> product = venderAdapter.getProducts();
            Console.WriteLine("Adapter Class Object Called Here : ");
            foreach (string item in product)
            {
                Console.Write("    " + item);
            }
        }

        /// <summary>
        /// method for Proxy design patterns.
        /// </summary>
        public static void ObserverProgram()
        {
            MyTopic topic = new MyTopic();
            IObserver obj1 = new MyTopicSubscriber("Obj1");
            IObserver obj2 = new MyTopicSubscriber("Obj2");
            IObserver obj3 = new MyTopicSubscriber("Obj3");
            topic.Register(obj1);
            topic.Register(obj2);
            topic.Register(obj3);
            obj1.SetSubject(topic);
            obj2.SetSubject(topic);
            obj3.SetSubject(topic);
            obj1.Update();
            topic.postMessage("New Message");
        }

        /// <summary>
        /// method for Shopping item.
        /// </summary>
        public static void Shopping()
        {
            ItemElement[] items = new ItemElement[]
            {
                new Book(20, "1234"), new Book(100, "5678"),
                new Fruit(10, 2, "Banana"), new Fruit(5, 5, "Apple")
            };
            int total = CalculatePrice(items);
            Console.WriteLine("Total Cost = " + total);
        }

        /// <summary>
        /// Method To Calculate the price.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <returns>sum</returns>
        private static int CalculatePrice(ItemElement[] items)
        {
            IShoppingCartVisitor visitor = new ShoppingCartVisitorImpl();
            int sum = 0;
            foreach (ItemElement item in items)
            {
                sum = sum + item.Accept(visitor);
            }

            return sum;
        }
    }
}
