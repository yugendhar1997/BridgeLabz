namespace DesignPattern
{
    using DesignPatterns.BehavioralDesignPattern;
    using DesignPatterns.CreationalPattern;
    using DesignPatterns.Singleton;
    using DesignPatterns.StructuralDesignPattern;
    using System;
    using System.Collections.Generic;
    using static DesignPatterns.BehavioralDesignPattern.ChatMediatorImp;
    using static DesignPatterns.BehavioralDesignPattern.MyTopic;

    /// <summary>
    /// This is main class of Program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            try
            {
                bool flag;
                int choice;
                do
                {
                    do
                    {
                        Console.WriteLine("");
                        Console.Write("Enter Your Choice: ");
                        flag = int.TryParse(Console.ReadLine(), out choice);
                        if (!flag)
                        {
                            Console.WriteLine("Enter input integer");
                        }
                    } while (!flag);
                    flag = false;
                    switch (choice)
                    {
                        case 1:
                            UtilitySingleton.SingletonType();
                            break;
                        case 2:
                            FactoryClient.ClientRequirement();
                            break;
                        case 3:
                            Cloning.CloningOperation();
                            break;
                        case 4:
                            Utility.VendorAdapterProgram();
                            break;
                        case 5:
                            ProxyDesignPattern.AtmWithdrawal();
                            break;
                        case 6:
                            Utility.ObserverProgram();
                            break;
                        case 7:
                            Utility.ChatMediatorProgram();
                            break;
                        case 8:
                            Utility.Shopping();
                            break;

                            Console.ReadKey();

                    }
                } while (!flag);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}