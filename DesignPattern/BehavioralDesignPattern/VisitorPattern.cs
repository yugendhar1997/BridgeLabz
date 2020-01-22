// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShoppingCartVisitor.cs" company="Bridgelabz">
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
    /// This is the class for Book which implement ItemElement.
    /// </summary>
    /// <seealso cref="DesignPattern.BehavioralDesignPatterns.ItemElement" />
    public class Book : ItemElement
    {
        private int price;
        private String isbnNumber;
        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class.
        /// </summary>
        /// <param name="cost">The cost.</param>
        /// <param name="isbn">The isbn.</param>
        public Book(int cost, String isbn)
        {
            this.price = cost;
            this.isbnNumber = isbn;
        }
        /// <summary>
        /// method to Get the price.
        /// </summary>
        /// <returns></returns>
        public int getPrice()
        {
            return price;
        }
        /// <summary>
        /// method to Get the book number.
        /// </summary>
        /// <returns></returns>
        public String getIsbnNumber()
        {
            return isbnNumber;
        }
        /// <summary>
        /// method to Accept the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        /// <returns></returns>
        public int accept(ShoppingCartVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
    /// <summary>
    /// This is the fruit class which implement ItemElement.
    /// </summary>
    /// <seealso cref="DesignPattern.BehavioralDesignPatterns.ItemElement" />
    public class Fruit : ItemElement
    {
        private int pricePerKg;
        private int weight;
        private String name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Fruit"/> class.
        /// </summary>
        /// <param name="priceKg">The price kg.</param>
        /// <param name="wt">The wt.</param>
        /// <param name="nm">The nm.</param>
        public Fruit(int priceKg, int wt, String nm)
        {
            this.pricePerKg = priceKg;
            this.weight = wt;
            this.name = nm;
        }
        /// <summary>
        /// method to Get the price per kg.
        /// </summary>
        /// <returns></returns>
        public int getPricePerKg()
        {
            return pricePerKg;
        }
        /// <summary>
        /// method to Get the weight.
        /// </summary>
        /// <returns></returns>
        public int getWeight()
        {
            return weight;
        }
        /// <summary>
        /// method to Get the name.
        /// </summary>
        /// <returns></returns>
        public String getName()
        {
            return this.name;
        }
        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        /// <returns></returns>
        public int accept(ShoppingCartVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
    /// <summary>
    /// class for ShoppingCartVisitorImplementation which implement ShoppingCartVisitor.
    /// </summary>
    /// <seealso cref="DesignPattern.BehavioralDesignPatterns.ShoppingCartVisitor" />
    public class ShoppingCartVisitorImpl : ShoppingCartVisitor
    {
        /// <summary>
        /// Visits the specified book.
        /// </summary>
        /// <param name="book">The book.</param>
        /// <returns></returns>
        public int visit(Book book)
        {
            int cost = 0;
            if (book.getPrice() > 50)
            {
                cost = book.getPrice() - 5;
            }
            else cost = book.getPrice();
            Console.WriteLine("Book ISBN::" + book.getIsbnNumber() + " cost =" + cost);
            return cost;
        }
        /// <summary>
        /// Visits the specified fruit.
        /// </summary>
        /// <param name="fruit">The fruit.</param>
        /// <returns></returns>
        public int visit(Fruit fruit)
        {
            int cost = fruit.getPricePerKg() * fruit.getWeight();
            Console.WriteLine(fruit.getName() + " cost = " + cost);
            return cost;
        }
    }
}
