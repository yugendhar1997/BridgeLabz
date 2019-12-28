using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class PrimeFactors
    {
        public void PrimeFactor()
        {
            Console.WriteLine("Enter A Number To Find the Prime Factors");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Prime Factors are :");
            Factors(number);
        }

        static void Factors(int number)
        {
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    if (isPrime(i))
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }

        static bool isPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
