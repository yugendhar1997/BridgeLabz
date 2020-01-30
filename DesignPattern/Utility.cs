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
            IChatMediator mediator = new ChatMediaImp();
            User user1 = new UserImp(mediator, "Yugendhar");
            User user2 = new UserImp(mediator, "Sunil");
            User user3 = new UserImp(mediator, "Praveen");
            User user4 = new UserImp(mediator, "Suresh");
            mediator.AddUser(user1);
            mediator.AddUser(user2);
            mediator.AddUser(user3);
            mediator.AddUser(user4);
            user1.Send("Hi Everyone");
        }

        /// <summary>
        /// method for Vendor adapter program.
        /// </summary>
        public static void VendorAdapterProgram()
        {
            VenderAdapter venderAdapter = new VenderAdapter();
            List<string> product = venderAdapter.GetProducts();
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
            IObserver object1 = new MyTopicSubscriber("Obj1");
            IObserver object2 = new MyTopicSubscriber("Obj2");
            IObserver object3 = new MyTopicSubscriber("Obj3");
            topic.Register(object1);
            topic.Register(object2);
            topic.Register(object3);
            object1.SetSubject(topic);
            object2.SetSubject(topic);
            object3.SetSubject(topic);
            object1.Update();
            topic.PostMessage("New Message");
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
        /// <returns>The sum</returns>
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
