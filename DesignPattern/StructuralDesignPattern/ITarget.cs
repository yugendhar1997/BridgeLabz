// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITarget.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.StructuralDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this is target interface it has get product abstract method
    /// </summary>
    public interface ITarget
    {
        /// <summary>
        /// this is abstract method
        /// </summary>
        /// <returns>list of product</returns>
        public List<string> getProducts();
    }

}
