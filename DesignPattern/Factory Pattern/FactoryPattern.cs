// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FactoryPattern.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.CreationalPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is an abstract class for FactoryPattern.
    /// </summary>
    public abstract class FactoryPattern
    {
        /// <summary>
        /// this is abstract method only declaration done.
        /// </summary>
        /// <param name="product">take a product name</param>
        /// <returns>it return object of Computer</returns>
        public abstract IComputer GetUserDecidedConfiguration(string product);
    }

    /// <summary>
    /// Factory implements Factory Pattern 
    /// </summary>
    /// <seealso cref="DesignPatterns.CreationalPattern.FactoryPattern" />
    public class ConcreateFactory : FactoryPattern
    {
        /// <summary>
        /// override the get configuration method
        /// </summary>
        /// <param name="newProduct">takes the product name</param>
        /// <returns>return the object of computer</returns>
        public override IComputer GetUserDecidedConfiguration(string newProduct)
        {
            //// this switch case use to decide which object should created at runtime
            switch (newProduct)
            {
                case "PC":
                    ////return PC object
                    return new PC();
                case "Laptop":
                    ////return Laptop object
                    return new Laptop();
                case "Server":
                    ////return Server object
                    return new Server();
                default:
                    return null;
            }
        }
    }

    /// <summary>
    /// this is interface computer which as get configuration abstract method
    /// </summary>
    public interface IComputer
    {
        /// <summary>
        /// Gets the configuration.
        /// </summary>
        abstract void GetConfiguration();
    }

    /// <summary>
    /// this class implemented from Computer class
    /// </summary>
    public class PC : IComputer
    {
        /// <summary>
        /// it hold Ram Of computer
        /// </summary>
        public string Ram = "4gb";

        /// <summary>
        /// it hold hardDisk Of computer
        /// </summary>
        public string HardDisk = "1Tb";

        /// <summary>
        /// it hold processor Of computer
        /// </summary>
        public string Processor = "I3";

        /// <summary>
        /// this is abstract method declaration
        /// </summary>
        public void GetConfiguration()
        {
            //// print all configuration of PC
            Console.WriteLine("PC Congiguration \nRam : " + this.Ram + "\nHardDisk :" + this.HardDisk + "\nProcessor :" + this.Processor);
        }
    }

    /// <summary>
    /// this is Laptop class
    /// </summary>
    public class Laptop : IComputer
    {
        /// <summary>
        /// The ram
        /// </summary>
        public string Ram = "8Gb";

        /// <summary>
        /// The hard disk
        /// </summary>
        public string HardDisk = "1Tb";

        /// <summary>
        /// The processor
        /// </summary>
        public string Processor = "I5";

        /// <summary>
        /// this is abstract method declaration
        /// </summary>
        public void GetConfiguration()
        {
            //// print all configuration of Laptop
            Console.WriteLine("Laptop Congiguration \nRam : " + this.Ram + "\nHardDisk :" + this.HardDisk + "\nProcessor :" + this.Processor);
        }
    }

    /// <summary>
    /// this is server class it has properties like Processor , Memory and NIC.
    /// </summary>
    public class Server : IComputer
    {
        /// <summary>
        /// it hold processor value of Server
        /// </summary>
        public string Processor = "Intel@ Xeon";

        /// <summary>
        /// it hold memory of processor
        /// </summary>
        public string Memory = "120Tb";

        /// <summary>
        /// It hold NIC card of Server
        /// </summary>
        public string Nic = "Dual";

        /// <summary>
        /// this is abstract method declaration
        /// </summary>
        public void GetConfiguration()
        {
            //// print server  configuration
            Console.WriteLine("Server Congiguration \nProcessor : " + this.Processor + "\nMemory : " + this.Memory + "\nNic :" + this.Nic);
        }
    }
}
