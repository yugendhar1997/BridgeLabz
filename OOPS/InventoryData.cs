// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryData.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OOPS
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    public class InventoryData
    {
        /// <summary>
        /// Gets or sets the rice.
        /// </summary>
        /// <value>
        /// The rice.
        /// </value>
        public IList<Rice> rice { get; set; }

        /// <summary>
        /// Gets or sets the wheat.
        /// </summary>
        /// <value>
        /// The wheat.
        /// </value>
        public IList<Wheat> Wheat { get; set; }

        /// <summary>
        /// Gets or sets the pulses.
        /// </summary>
        /// <value>
        /// The pulses.
        /// </value>
        public IList<Pulses> pulses { get; set; }
    }

    public class Rice
    {

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public double price { get; set; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public double weight { get; set; }

    }

    public class Wheat
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public double price { get; set; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public double weight { get; set; }
    }

    public class Pulses
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public int name { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public double price { get; set; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public double weight { get; set; }
    }
}
