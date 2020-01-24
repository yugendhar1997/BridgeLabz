// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Reflection.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Singleton
{
    using System;
    using System.Reflection;

    /// <summary>
    /// This is the class for reflection.
    /// </summary>
    public class Reflection
    {
        /// <summary>
        /// method for Reflection operation.
        /// </summary>
        public static void ReflectionOperation()
        {
            ReflectionCompany reflectionCompany = new ReflectionCompany();
            Type typeOfCompany = typeof(ReflectionCompany);
            Console.WriteLine("Type : " + typeOfCompany.Name);
            Console.WriteLine("NameSpace : " + typeOfCompany.Namespace);

            PropertyInfo[] propertyInfo = typeOfCompany.GetProperties();

            Console.WriteLine("The list of properties of the class are : ");

            foreach (PropertyInfo property in propertyInfo)
            {
                Console.WriteLine(property.Name);
            }

            MethodInfo[] methodInfo = typeOfCompany.GetMethods();
            Console.WriteLine("Method List : ");
            foreach (MethodInfo method in methodInfo)
            {
                Console.WriteLine(method.Name);
            }
        }
    }
}
