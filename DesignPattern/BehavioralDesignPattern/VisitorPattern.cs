// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VisitorPattern.cs" company="Bridgelabz">
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
        /// <summary>
        /// The Price
        /// </summary>
        private int price;

        /// <summary>
        /// The Number
        /// </summary>
        private string isbnNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class.
        /// </summary>
        /// <param name="cost">The cost.</param>
        /// <param name="isbn">The Book Number.</param>
        public Book(int cost, string isbn)
        {
            this.price = cost;
            this.isbnNumber = isbn;
        }

        /// <summary>
        /// method to Get the price.
        /// </summary>
        /// <returns>The Price</returns>
        public int GetPrice()
        {
            return this.price;
        }

        /// <summary>
        /// method to Get the book number.
        /// </summary>
        /// <returns>Book Number</returns>
        public string GetIsbnNumber()
        {
            return this.isbnNumber;
        }

        /// <summary>
        /// method to Accept the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        /// <returns>The Visitor</returns>
        public int Accept(IShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }

    /// <summary>
    /// This is the fruit class which implement ItemElement.
    /// </summary>
    public class Fruit : ItemElement
    {
        /// <summary>
        /// Price Per Kg
        /// </summary>
        private int pricePerKg;

        /// <summary>
        /// The Weight
        /// </summary>
        private int weight;

        /// <summary>
        /// The Name
        /// </summary>
        private string name;

        /// <summary>
        /// Fruit
        /// </summary>
        /// <param name="priceKg">The Price</param>
        /// <param name="weight">The Weight</param>
        /// <param name="name">The Name</param>
        public Fruit(int priceKg, int weight, string name)
        {
            this.pricePerKg = priceKg;
            this.weight = weight;
            this.name = name;
        }

        /// <summary>
        /// method to Get the price per kg.
        /// </summary>
        /// <returns>The Price</returns>
        public int GetPricePerKg()
        {
            return this.pricePerKg;
        }

        /// <summary>
        /// method to Get the weight.
        /// </summary>
        /// <returns>The Weight</returns>
        public int GetWeight()
        {
            return this.weight;
        }

        /// <summary>
        /// method to Get the name.
        /// </summary>
        /// <returns>The Name</returns>
        public string GetName()
        {
            return this.name;
        }

        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        /// <returns>The Visitor</returns>
        public int Accept(IShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }

    /// <summary>
    /// class for ShoppingCartVisitorImplementation which implement ShoppingCartVisitor.
    /// </summary>
    /// <seealso cref="DesignPattern.BehavioralDesignPatterns.ShoppingCartVisitor" />
    public class ShoppingCartVisitorImpl : IShoppingCartVisitor
    {
        /// <summary>
        /// Visits the specified book.
        /// </summary>
        /// <param name="book">The book.</param>
        /// <returns>The cost</returns>
        public int Visit(Book book)
        {
            int cost = 0;
            if (book.GetPrice() > 50)
            {
                cost = book.GetPrice() - 5;
            }
            else
            {
                cost = book.GetPrice();
            }

            Console.WriteLine("Book ISBN::" + book.GetIsbnNumber() + " cost =" + cost);
            return cost;
        }

        /// <summary>
        /// Visits the specified fruit.
        /// </summary>
        /// <param name="fruit">The fruit.</param>
        /// <returns>The cost</returns>
        public int Visit(Fruit fruit)
        {
            int cost = fruit.GetPricePerKg() * fruit.GetWeight();
            Console.WriteLine(fruit.GetName() + " cost = " + cost);
            return cost;
        }
    }
}
