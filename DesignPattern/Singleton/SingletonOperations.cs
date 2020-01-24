// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SingletonOperations.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Singleton
{
    using System;
    using DesignPatterns.Singleton;

    /// <summary>
    /// this is singleton utility this class provide choice to user
    /// </summary>
    public class SingletonOperations
    {
        /// <summary>
        /// this method display list of operation to perform
        /// </summary>
        public static void SingletonType()
        {
            string repeat;
            try
            {
                do
                {
                    Console.WriteLine(" Press 1 : Eager Singleton");
                    Console.WriteLine(" Press 2 : Lazy Singleton");
                    Console.WriteLine(" Press 3 : Thread Safe Singleton");
                    Console.WriteLine(" Press 4 : Reflection");
                    Console.WriteLine(" Press 5 : Bill Pugh Singleton");
                    Console.WriteLine("Enter Your Choice To Run Operation ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            EagerSingleton();
                            break;
                        case 2:
                            LazySingleton();
                            break;
                        case 3:
                            SingleTonThreadSafe();
                            break;
                        case 4:
                            Reflection.ReflectionOperation();
                            break;
                        case 5:
                            BillPugh();
                            break;

                        default:
                            Console.WriteLine("Please Enter Valide Number");
                            break;
                    }

                    Console.WriteLine("\nDo You want To Continue the Press 'Yes' Or 'No' ");
                    repeat = Console.ReadLine().ToLower();
                }
                while (repeat == "yes");
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Please Enter Valide Input " + exception);
            }
        }

        /// <summary>
        /// Eager Singleton it create single object only
        /// </summary>
        public static void EagerSingleton()
        {
            EagerInitialization singletonObject = EagerInitialization.GetSingleton;
            singletonObject.Message("This Is Eager Singletone");
        }

       /// <summary>
       /// Lazy Singleton
       /// </summary>
        public static void LazySingleton()
        {
            SingletonLazy singletonLazy = SingletonLazy.GetSingleton;
            singletonLazy.Message("This Is Lazy Singleton");
        }

        /// <summary>
        /// this method provide thread safe implementation
        /// </summary>
        public static void SingleTonThreadSafe()
        {
            ThreadSafeSingleton singletonThreadSafe = ThreadSafeSingleton.GetSingleton;
            singletonThreadSafe.Message("This Is Singleton Thread Safe");
        }

        public static void BillPugh()
        {
            BillPughSingleton billPughSingleton = BillPughSingleton.GetInstance();
            billPughSingleton.Message("This Is Bill Pugh Singletone");
        }

        /// <summary>
        /// method for the First message.
        /// </summary>
        private static void FirstMessage()
        {
            SingletonLazy threadSafeFirst = SingletonLazy.GetSingleton;
            threadSafeFirst.Message("This is First Message");
        }

        /// <summary>
        /// This method used by Simple Singleton
        /// </summary>
        private static void SecondMessage()
        {
            SingletonLazy threadSafeSecond = SingletonLazy.GetSingleton;
            threadSafeSecond.Message("This is Second Message");
        }
    }
}
