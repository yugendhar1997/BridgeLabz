// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShoppingCartVisitor.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehavioralDesignPattern
{
    using DesignPatterns.StructuralDesignPattern;
    using System;
    using System.Collections.Generic;
    using System.Text;
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
            ChatMediator mediator = new ChatMediatorImp();
            User user1 = new UserImpl(mediator, "Pankaj");
            User user2 = new UserImpl(mediator, "Lisa");
            User user3 = new UserImpl(mediator, "Saurabh");
            User user4 = new UserImpl(mediator, "David");
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
                Console.Write("    " + item);
        }

        /// <summary>
        /// method for Proxy design patterns.
        /// </summary>
        public static void ObserverProgram()
        {
            MyTopic topic = new MyTopic();
            Observer obj1 = new MyTopicSubscriber("Obj1");
            Observer obj2 = new MyTopicSubscriber("Obj2");
            Observer obj3 = new MyTopicSubscriber("Obj3");
            topic.register(obj1);
            topic.register(obj2);
            topic.register(obj3);
            obj1.setSubject(topic);
            obj2.setSubject(topic);
            obj3.setSubject(topic);
            obj1.update();
            topic.postMessage("New Message");
        }

        /// <summary>
        /// method for Shoppings item.
        /// </summary>
        public static void Shopping()
        {
            ItemElement[] items = new ItemElement[]{new Book(20, "1234"),new Book(100, "5678"),
      new Fruit(10, 2, "Banana"), new Fruit(5, 5, "Apple")};
            int total = calculatePrice(items);
            Console.WriteLine("Total Cost = " + total);
        }

        /// <summary>
        /// Method To Calculate the price.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <returns></returns>
        private static int calculatePrice(ItemElement[] items)
        {
            ShoppingCartVisitor visitor = new ShoppingCartVisitorImpl();
            int sum = 0;
            foreach (ItemElement item in items)
            {
                sum = sum + item.accept(visitor);
            }
            return sum;
        }
    }
}
