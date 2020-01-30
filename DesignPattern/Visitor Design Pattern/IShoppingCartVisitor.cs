// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IShoppingCartVisitor.cs" company="Bridgelabz">
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
    /// This is an interface for ShoppingCartVisitor.
    /// </summary>
    public interface IShoppingCartVisitor
    {
        /// <summary>
        /// Visits the specified book.
        /// </summary>
        /// <param name="book">The book.</param>
        /// <returns>The book</returns>
        int Visit(Book book);

        /// <summary>
        /// Visits the specified fruit.
        /// </summary>
        /// <param name="fruit">The fruit.</param>
        /// <returns>The fruit</returns>
        int Visit(Fruit fruit);
    }

    /// <summary>
    /// this is an interface of ItemElement.
    /// </summary>
    public interface ItemElement
    {
        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        /// <returns>The visitor</returns>
        public int Accept(IShoppingCartVisitor visitor);
    }
}
