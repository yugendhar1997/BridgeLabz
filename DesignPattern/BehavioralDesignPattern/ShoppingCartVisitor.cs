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
    /// This is an interface for ShoppingCartVisitor.
    /// </summary>
    public interface ShoppingCartVisitor
    {
        /// <summary>
        /// Visits the specified book.
        /// </summary>
        /// <param name="book">The book.</param>
        /// <returns></returns>
        int visit(Book book);
        /// <summary>
        /// Visits the specified fruit.
        /// </summary>
        /// <param name="fruit">The fruit.</param>
        /// <returns></returns>
        int visit(Fruit fruit);
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
        /// <returns></returns>
        public int accept(ShoppingCartVisitor visitor);
    }
}
